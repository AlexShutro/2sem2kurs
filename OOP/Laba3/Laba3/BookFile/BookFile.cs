using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Laba2.BookFile
{
    public class BookFile
    {
        public BookFile(Format format, int size, string name, string udc, int numberOfPages, PublishingHouse publishingHouse, int year,
            List<Author> authors)
        {
            Format = format;
            Size = size;
            Name = name;
            Udc = udc;
            NumberOfPages = numberOfPages;
            PublishingHouse = publishingHouse;
            Year = year;
            Authors = authors;
        }
        [Required]
        public Format Format { get; set; }
        [Required]
        [Range(1, 100 , ErrorMessage = "Превышение значение размера") ]
        public int Size { get; set; }
        [Required]
        [StringLength(50, MinimumLength=3 , ErrorMessage = "Длина названия от 3 до 50")]
        public string Name { get; set; }
        [Required]
        [Udc(ErrorMessage ="Недопустомое значение УДК")]
        public string Udc { get; set; }
        [Required]
        [Range(1, 1000 , ErrorMessage = "Значение числа страниц от 1 до 1000 ") ]
        public int NumberOfPages { get; set; }
        [Required]
        public PublishingHouse PublishingHouse { get; set; }
        [Required]
        public int Year { get; set; }
        [Required]
        public List<Author> Authors { get; set; }

        public override string ToString()
        {
            return string.Format("Format - {0}, Size - {1}(mb) , Name - {2} , UDC - {3} , Year - {4} , number of pages - {5}", Format, Size, Name,
                Udc, Year, NumberOfPages);
        }
    }
}