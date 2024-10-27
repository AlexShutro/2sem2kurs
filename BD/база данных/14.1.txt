ALTER SESSION SET "_oracle_script" = TRUE;
CREATE USER Prodavshiza IDENTIFIED BY prod;
set serveroutput on;

GRANT CREATE TABLE TO Prodavshiza;
GRANT CREATE PROCEDURE TO Prodavshiza;
GRANT CREATE TRIGGER TO Prodavshiza;
GRANT CREATE SESSION TO Prodavshiza;
GRANT SELECT ANY TABLE TO Prodavshiza;
GRANT UPDATE ANY TABLE TO Prodavshiza;
GRANT INSERT ANY TABLE TO Prodavshiza;
GRANT EXECUTE ANY PROCEDURE TO Prodavshiza;
ALTER USER Prodavshiza QUOTA UNLIMITED ON USERS;
GRANT ADMINISTER DATABASE TRIGGER TO Prodavshiza;
GRANT CREATE VIEW TO Prodavshiza;




-- Task 1
CREATE TABLE lorek (
    id NUMBER PRIMARY KEY,
    ovoshchi VARCHAR2(50),
    fructi VARCHAR2(50),
    coast NUMBER
);
SELECT * FROM LOREK;

-- Task 2
INSERT INTO lorek (id, ovoshchi, fructi, coast) VALUES  (1, 'Морковь', 'Яблоки', 2.50);
INSERT INTO lorek (id, ovoshchi, fructi, coast) VALUES  (2, 'Помидоры', 'Апельсины', 3.20);
INSERT INTO lorek (id, ovoshchi, fructi, coast) VALUES  (3, 'Огурцы', 'Бананы', 1.80);
INSERT INTO lorek (id, ovoshchi, fructi, coast) VALUES  (4, 'Капуста', 'Груши', 2.70);
INSERT INTO lorek (id, ovoshchi, fructi, coast) VALUES  (5, 'Перец', 'Сливы', 4.10);
INSERT INTO lorek (id, ovoshchi, fructi, coast) VALUES  (6, 'Лук', 'Персики', 3.00);
INSERT INTO lorek (id, ovoshchi, fructi, coast) VALUES  (7, 'Картофель', 'Виноград', 2.90);
INSERT INTO lorek (id, ovoshchi, fructi, coast) VALUES  (8, 'Редис', 'Арбуз', 5.50);
INSERT INTO lorek (id, ovoshchi, fructi, coast) VALUES  (9, 'Редька', 'Дыня', 4.80);
INSERT INTO lorek (id, ovoshchi, fructi, coast) VALUES  (10, 'Чеснок', 'Киви', 3.70);

-- Task 3
CREATE OR REPLACE TRIGGER before_trigger_operator
BEFORE INSERT OR DELETE OR UPDATE ON lorek
BEGIN
    IF INSERTING THEN
        DBMS_OUTPUT.PUT_LINE('Триггер BEFORE для вставки вызван');
    ELSIF DELETING THEN
        DBMS_OUTPUT.PUT_LINE('Триггер BEFORE для удаления вызван');
    ELSIF UPDATING THEN
        DBMS_OUTPUT.PUT_LINE('Триггер BEFORE для обновления вызван');
    END IF;
END;
INSERT INTO lorek (id, ovoshchi, fructi, coast) VALUES (15, 'Редис', 'Бананы', 2.90);


-- Task 4
CREATE OR REPLACE TRIGGER before_trigger_row
BEFORE INSERT OR DELETE OR UPDATE ON lorek
FOR EACH ROW
BEGIN
    IF INSERTING THEN
        DBMS_OUTPUT.PUT_LINE('Триггер BEFORE для вставки вызван для строки с идентификатором ' || :NEW.id);
    ELSIF DELETING THEN
        DBMS_OUTPUT.PUT_LINE('Триггер BEFORE для удаления вызван для строки с идентификатором ' || :OLD.id);
    ELSIF UPDATING THEN
        DBMS_OUTPUT.PUT_LINE('Триггер BEFORE для обновления вызван для строки с идентификатором ' || :OLD.id);
    END IF;
END;


-- Task 5
CREATE OR REPLACE TRIGGER after_trigger_operator
AFTER INSERT OR DELETE OR UPDATE ON lorek
BEGIN
    IF INSERTING THEN
        DBMS_OUTPUT.PUT_LINE('Триггер AFTER для вставки вызван');
    ELSIF DELETING THEN
        DBMS_OUTPUT.PUT_LINE('Триггер AFTER для удаления вызван');
    ELSIF UPDATING THEN
        DBMS_OUTPUT.PUT_LINE('Триггер AFTER для обновления вызван');
    END IF;
END;

-- Task 6
CREATE OR REPLACE TRIGGER after_trigger_row
AFTER INSERT OR DELETE OR UPDATE ON lorek
FOR EACH ROW
BEGIN
    IF INSERTING THEN
        DBMS_OUTPUT.PUT_LINE('Триггер AFTER для вставки вызван для строки с идентификатором ' || :NEW.id);
    ELSIF DELETING THEN
        DBMS_OUTPUT.PUT_LINE('Триггер AFTER для удаления вызван для строки с идентификатором ' || :OLD.id);
    ELSIF UPDATING THEN
        DBMS_OUTPUT.PUT_LINE('Триггер AFTER для обновления вызван для строки с идентификатором ' || :OLD.id);
    END IF;
END;


-- Task 8
DROP TABLE AUDITOR;
CREATE TABLE AUDITOR (
    OperationDate DATE,
    OperationType VARCHAR2(1000),
    TriggerName VARCHAR2(50),
    Data VARCHAR2(4000)
);


-- Task 9
CREATE OR REPLACE TRIGGER before_trigger_operator
BEFORE INSERT OR DELETE OR UPDATE ON lorek
DECLARE
    v_data VARCHAR2(4000);
    v_operation_type VARCHAR2(1000);
BEGIN
    IF INSERTING THEN
        v_data := 'Операция INSERT';
    ELSIF DELETING THEN
        v_data := 'Операция DELETE';
    ELSIF UPDATING THEN
        v_data := 'Операция UPDATE';
    END IF;


    INSERT INTO AUDITOR (OperationDate, OperationType, TriggerName, Data)
    VALUES (SYSDATE, v_operation_type, 'before_trigger_operator', NULL);
END;


INSERT INTO lorek (id, ovoshchi, fructi, coast) VALUES (12, 'Картофель', 'Апельсины', 2.90);

CREATE OR REPLACE TRIGGER before_trigger_row
BEFORE INSERT OR DELETE OR UPDATE ON lorek
FOR EACH ROW
DECLARE
    v_data VARCHAR2(4000);
BEGIN
    IF INSERTING THEN
        v_data := 'Inserting values: ' || :NEW.id || ', ' || :NEW.ovoshchi || ', ' || :NEW.fructi || ', ' || :NEW.coast;
    ELSIF DELETING THEN
        v_data := 'Deleting values: ' || :OLD.id || ', ' || :OLD.ovoshchi || ', ' || :OLD.fructi || ', ' || :OLD.coast;
    ELSIF UPDATING THEN
        v_data := 'Updating from: ' || :OLD.id || ', ' || :OLD.ovoshchi || ', ' || :OLD.fructi || ', ' || :OLD.coast ||
                  ' to: ' || :NEW.id || ', ' || :NEW.ovoshchi || ', ' || :NEW.fructi || ', ' || :NEW.coast;
    END IF;

    INSERT INTO AUDITOR (OperationDate, OperationType, TriggerName, Data)
    VALUES (SYSDATE, 'BEFORE ROW ' || v_data, 'before_trigger_row', v_data);
END;


CREATE OR REPLACE TRIGGER after_trigger_operator
AFTER INSERT OR DELETE OR UPDATE ON lorek
DECLARE
    v_data VARCHAR2(4000);
BEGIN
    IF INSERTING THEN
        v_data := 'INSERT Operation';
    ELSIF DELETING THEN
        v_data := 'DELETE Operation';
    ELSIF UPDATING THEN
        v_data := 'UPDATE Operation';
    END IF;

    INSERT INTO AUDITOR (OperationDate, OperationType, TriggerName, Data)
    VALUES (SYSDATE, 'AFTER ' || v_data, 'after_trigger_operator', NULL);
END;



CREATE OR REPLACE TRIGGER after_trigger_row
AFTER INSERT OR DELETE OR UPDATE ON lorek
FOR EACH ROW
DECLARE
    v_data VARCHAR2(4000);
BEGIN
    IF INSERTING THEN
        v_data := 'Inserted values: ' || :NEW.id || ', ' || :NEW.ovoshchi || ', ' || :NEW.fructi || ', ' || :NEW.coast;
    ELSIF DELETING THEN
        v_data := 'Deleted values: ' || :OLD.id || ', ' || :OLD.ovoshchi || ', ' || :OLD.fructi || ', ' || :OLD.coast;
    ELSIF UPDATING THEN
        v_data := 'Updated from: ' || :OLD.id || ', ' || :OLD.ovoshchi || ', ' || :OLD.fructi || ', ' || :OLD.coast ||
                  ' to: ' || :NEW.id || ', ' || :NEW.ovoshchi || ', ' || :NEW.fructi || ', ' || :NEW.coast;
    END IF;

    INSERT INTO AUDITOR (OperationDate, OperationType, TriggerName, Data)
    VALUES (SYSDATE, 'AFTER ROW ' || v_data, 'after_trigger_row', v_data);
END;

-- Task 10
INSERT INTO lorek (id, ovoshchi, fructi, coast) VALUES (1, 'Тыква', 'Манго', 3.50);
SELECT * FROM AUDITOR;

-- Task 11
DROP TABLE lorek;

CREATE OR REPLACE TRIGGER prevent_drop_lorek 
BEFORE DROP ON DATABASE
DECLARE
    PRAGMA AUTONOMOUS_TRANSACTION;
BEGIN
    IF ORA_DICT_OBJ_NAME = 'LOREK' AND ORA_DICT_OBJ_OWNER = 'PRODAVSHIZA' THEN
        RAISE_APPLICATION_ERROR(-20000, 'Удаление таблицы lorek запрещено!');
    END IF;
END;

-- Task 12
DROP TABLE AUDITOR;

CREATE OR REPLACE TRIGGER before_trigger_operator
BEFORE INSERT OR DELETE OR UPDATE ON lorek
DECLARE
    v_data VARCHAR2(4000);
BEGIN
    BEGIN
        SELECT COUNT(*) INTO v_data FROM ALL_TABLES WHERE TABLE_NAME = 'AUDITOR' AND OWNER = 'PRODAVSHIZA';
        IF v_data > 0 THEN
            IF INSERTING THEN
                v_data := 'INSERT Operation';
            ELSIF DELETING THEN
                v_data := 'DELETE Operation';
            ELSIF UPDATING THEN
                v_data := 'UPDATE Operation';
            END IF;
            INSERT INTO AUDITOR (OperationDate, OperationType, TriggerName, Data)
            VALUES (SYSDATE, 'BEFORE ' || v_data, 'before_trigger_operator', NULL);
        END IF;
    EXCEPTION
        WHEN NO_DATA_FOUND THEN NULL;
    END;
END;

-- Task 13
CREATE VIEW lorek_view AS SELECT * FROM lorek;


CREATE OR REPLACE TRIGGER instead_of_update_trigger
INSTEAD OF UPDATE ON lorek_view
FOR EACH ROW
BEGIN
    UPDATE lorek SET
        ovoshchi = :NEW.ovoshchi,
        fructi = :NEW.fructi,
        coast = :NEW.coast
    WHERE id = :OLD.id;

    INSERT INTO lorek (id, ovoshchi, fructi, coast)
    VALUES (:NEW.id, :NEW.ovoshchi, :NEW.fructi, :NEW.coast);
END;

-- Task 14
-- BEFORE statement-level trigger
-- BEFORE row-level trigger
-- AFTER row-level trigger
-- AFTER statement-level trigger

-- Task 15
CREATE OR REPLACE TRIGGER first_trigger
BEFORE INSERT ON lorek
BEGIN
    DBMS_OUTPUT.PUT_LINE('First trigger executed');
END;

CREATE OR REPLACE TRIGGER second_trigger
BEFORE INSERT ON lorek
BEGIN
    DBMS_OUTPUT.PUT_LINE('Second trigger executed');
END;

CREATE OR REPLACE TRIGGER first_trigger
BEFORE INSERT ON lorek
FOLLOWS second_trigger
BEGIN
    DBMS_OUTPUT.PUT_LINE('First trigger executed');
END;
INSERT INTO lorek (id, ovoshchi, fructi, coast) VALUES (17, 'Редис', 'Бананы', 2.90);
