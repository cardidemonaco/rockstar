using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace rockstar.Data.Entities
{
    public class Person
    {
        [Key]
        [Required]
        public int PersonID { get; set; }
        [Required]
        [Display(Name = "First Name")]
        public string PersonNameFirst { get; set; }
        [Display(Name = "Middle Name")]
        public string PersonNameMiddle { get; set; }
        [Display(Name = "Last Name")]
        public string PersonNameLast { get; set; }
        public string PersonNameFull
        {
            get
            {
                if (PersonNameMiddle != null && PersonNameMiddle.Length > 0)
                    return $"{PersonNameFirst} {PersonNameMiddle} {PersonNameLast}";
                else
                    return $"{PersonNameFirst} {PersonNameLast}";
            }
        }
        [Display(Name = "Gender")]
        public int PersonGender { get; set; } // 1=Female; 2=Male
        [Display(Name = "Birth Date")]
        public DateTime? PersonBirthdate { get; set; }
        [Display(Name = "Birth Month")]
        public int? PersonBirthdateMonth { get; set; } //This field will ony be used if exact year of birth is unknown
        [Display(Name = "Birth Day")]
        public int? PersonBirthdateDay { get; set; } //This field will ony be used if exact year of birth is unknown
        [Display(Name = "Death Date")]
        public DateTime? PersonDeathDate { get; set; }
        public string PersonLifespan
        {
            get
            {
                //If person has passed away...
                if (PersonDeathDate != null)
                    return $"{PersonBirthdate} - {PersonDeathDate}";
                //Else person has not passed away...
                else
                    return $"born {PersonBirthdate}";
            }
        }

        public int? PersonAge
        {
            get
            {
                //If birthdate and deathdate known...
                if (PersonBirthdate.HasValue && PersonDeathDate.HasValue)
                {
                    //Calculate age at death...
                    if (PersonDeathDate.Value.Month >= PersonBirthdate.Value.Month && PersonDeathDate.Value.Day >= PersonBirthdate.Value.Day)
                        return PersonDeathDate.Value.Year - PersonBirthdate.Value.Year;
                    else
                        return PersonDeathDate.Value.Year - PersonBirthdate.Value.Year - 1; //Person did not have birthday the year they passed away
                }
                //If only birthdate known...
                else if (PersonBirthdate.HasValue)
                {
                    //Save current date/time...
                    var dt = TimeZoneInfo.ConvertTime(DateTime.Now, TimeZoneInfo.FindSystemTimeZoneById("Eastern Standard Time"));

                    //Calculate age...
                    var hadBirthday = new DateTime(dt.Year, PersonBirthdate.Value.Month, PersonBirthdate.Value.Day) < dt ? 0 : -1;
                    return dt.Year - PersonBirthdate.Value.Year + hadBirthday;
                }
                //Else birthdate unknown...
                else
                {
                    return null;
                }
            }
        }
        public string PersonDetails { get; set; }
    }
}
