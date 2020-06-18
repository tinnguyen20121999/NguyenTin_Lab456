using NguyenTin_lab456.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Web;

namespace NguyenTin_lab456.ViewModels
{
    public class CourseViewModel
    {

        [Required]
        public string Place { get; set;}
        [Required]
        [FutureDate]
        public string Date { get; set; }
        [Required]
        [ValidTime]
        public string Time { get; set; }
        [Required]
        public byte Category { get; set; }
        public IEnumerable<Category> Categories { get; set;}
        public DateTime GetDateTime()
        {
            DateTime newDate = DateTime.ParseExact(Date, "dd/MM/yyy", CultureInfo.InvariantCulture); ;
            string newDate2 = newDate.Year + "-" + newDate.Month + "-" + newDate.Day;
            string fullDate = newDate2 + "" + Time;
            var insert = DateTime.ParseExact(fullDate, "yyyy-M-dd hh:mm", CultureInfo.InvariantCulture);
            return DateTime.Parse(insert.ToString());
        }
    }
}