-- Task 1
CREATE TABLE T_RANGE (
    id NUMBER,
    name VARCHAR2(50)
)
PARTITION BY RANGE (id) (
    PARTITION p1 VALUES LESS THAN (100),
    PARTITION p2 VALUES LESS THAN (200),
    PARTITION p3 VALUES LESS THAN (MAXVALUE)
);

-- Task 2
CREATE TABLE T_INTERVAL (
    id NUMBER,
    date_column DATE
)
PARTITION BY RANGE (date_column) 
INTERVAL (NUMTOYMINTERVAL(1, 'MONTH')) (
    PARTITION p1 VALUES LESS THAN (TO_DATE('01-01-2020', 'DD-MM-YYYY'))
);

-- Task 3
CREATE TABLE T_HASH (
    id NUMBER,
    text_column VARCHAR2(50)
)
PARTITION BY HASH (id) PARTITIONS 4;

-- Task 4
CREATE TABLE T_LIST (
    id CHAR(1),
    description VARCHAR2(50)
)
PARTITION BY LIST (id) (
    PARTITION p1 VALUES ('A'),
    PARTITION p2 VALUES ('B'),
    PARTITION p3 VALUES ('C')
);

-- Task 5
INSERT INTO T_RANGE VALUES (50, 'Section 1');
INSERT INTO T_RANGE VALUES (150, 'Section 2');
INSERT INTO T_RANGE VALUES (250, 'Section 3');

INSERT INTO T_INTERVAL VALUES (1, TO_DATE('01-01-2020', 'DD-MM-YYYY'));
INSERT INTO T_INTERVAL VALUES (2, TO_DATE('01-02-2020', 'DD-MM-YYYY'));
INSERT INTO T_INTERVAL VALUES (3, TO_DATE('01-03-2020', 'DD-MM-YYYY'));

INSERT INTO T_HASH VALUES (1, 'Hash Section 1');
INSERT INTO T_HASH VALUES (2, 'Hash Section 2');
INSERT INTO T_HASH VALUES (3, 'Hash Section 3');

INSERT INTO T_LIST VALUES ('A', 'List Section 1');
INSERT INTO T_LIST VALUES ('B', 'List Section 2');
INSERT INTO T_LIST VALUES ('C', 'List Section 3');

-- Task 6
------------------------------------------------------------------------------------------------
CREATE GLOBAL TEMPORARY TABLE temp_t_range AS 
SELECT * FROM T_RANGE WHERE 1=0;
BEGIN
    INSERT INTO temp_t_range
    SELECT * FROM T_RANGE WHERE id = 50;
    DELETE FROM T_RANGE WHERE id = 50;
    INSERT INTO T_RANGE (id, name)
    SELECT 150, name FROM temp_t_range;
    DELETE FROM temp_t_range;
END;
SELECT * FROM T_RANGE WHERE id = 50;
SELECT * FROM T_RANGE WHERE id = 150;
UPDATE T_RANGE SET id = 150 WHERE id = 50;
-----------------------------------------------------------------------------------------------
CREATE GLOBAL TEMPORARY TABLE temp_t_interval AS 
SELECT * FROM T_INTERVAL WHERE 1=0;

BEGIN
    INSERT INTO temp_t_interval
    SELECT * FROM T_INTERVAL WHERE id = 1;
    DELETE FROM T_INTERVAL WHERE id = 1;
    INSERT INTO T_INTERVAL (id, date_column)
    SELECT id, TO_DATE('01-02-2020', 'DD-MM-YYYY') FROM temp_t_interval;
    DELETE FROM temp_t_interval;
    COMMIT;
END;

SELECT * FROM T_INTERVAL WHERE id = 1 AND date_column = TO_DATE('01-01-2020', 'DD-MM-YYYY');
SELECT * FROM T_INTERVAL WHERE id = 1 AND date_column = TO_DATE('01-02-2020', 'DD-MM-YYYY');

UPDATE T_INTERVAL SET date_column = TO_DATE('01-02-2020', 'DD-MM-YYYY') WHERE id = 1;
-----------------------------------------------------------------------------------------------
CREATE GLOBAL TEMPORARY TABLE temp_t_hash AS 
SELECT * FROM T_HASH WHERE 1=0;
BEGIN
    INSERT INTO temp_t_hash
    SELECT * FROM T_HASH WHERE id = 1;

    DELETE FROM T_HASH WHERE id = 1;

    INSERT INTO T_HASH (id, text_column)
    SELECT 2, text_column FROM temp_t_hash;

    DELETE FROM temp_t_hash;

    COMMIT;
END;

SELECT * FROM T_HASH WHERE id = 1;
SELECT * FROM T_HASH WHERE id = 2;

UPDATE T_HASH SET id = 2 WHERE id = 1;
-----------------------------------------------------------------------------------------------

SELECT * FROM T_LIST WHERE id = 'B';
BEGIN
    DELETE FROM T_LIST WHERE id = 'A';
    INSERT INTO T_LIST (id, description) VALUES ('B', 'Та ты шо, работает');
    COMMIT;
END;


UPDATE T_LIST SET id = 'B' WHERE id = 'A';
-----------------------------------------------------------------------------------------------

-- Task 7
ALTER TABLE T_RANGE MERGE PARTITIONS p1, p2 INTO PARTITION p_merged;

SELECT PARTITION_NAME, HIGH_VALUE FROM USER_TAB_PARTITIONS
WHERE TABLE_NAME = 'T_RANGE';


-- Task 8
ALTER TABLE T_RANGE SPLIT PARTITION p_merged AT (100) INTO (PARTITION p1, PARTITION p2);

-- Task 9
CREATE TABLE T_LIST_TEST (
    id CHAR(1),
    description VARCHAR2(50)
)
PARTITION BY LIST (id) (
    PARTITION p1 VALUES ('A'),
    PARTITION p2 VALUES ('B'),
    PARTITION p3 VALUES ('C')
);

INSERT INTO T_LIST_TEST VALUES ('A', 'List Section 1');
INSERT INTO T_LIST_TEST VALUES ('B', 'List Section 2');
INSERT INTO T_LIST_TEST VALUES ('C', 'List Section 3');

SELECT * FROM T_LIST_TEST PARTITION (p2);
SELECT * FROM T_LIST PARTITION (p1);

CREATE TABLE T_LIST_TEST_TEMP AS SELECT * FROM T_LIST_TEST WHERE 1=0;

ALTER TABLE T_LIST_TEST EXCHANGE PARTITION p1 WITH TABLE T_LIST_TEST_TEMP;

DROP TABLE T_LIST_TEST_TEMP;

SELECT * FROM T_LIST_TEST PARTITION (p2);
SELECT * FROM T_LIST PARTITION (p1);



-- Task 10
-- 2.1
SELECT table_name FROM user_part_tables;

SELECT partition_name, high_value, tablespace_name FROM user_tab_partitions
WHERE table_name = 'T_RANGE';

-- 2.2
SELECT partition_name
FROM user_tab_partitions
WHERE table_name = 'T_RANGE';

-- 2.3 Список всех значений из секции 'p1' по имени секции
SELECT * FROM T_RANGE PARTITION (p1);

-- 2.4 Список всех значений из секции 'p1' по ссылке
SELECT * FROM T_RANGE
WHERE id < 100;

