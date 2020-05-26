using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic
{
    public class Course
    {
        private string courseName;
        private byte numCredits;
        private byte maxCredits = 30;

        public Course(string courseName)
        {
            CourseName = courseName;
            InstructorName = "STAFF";
        }

        /// <summary>
        /// The instructor teaching the course
        /// </summary>
        public string InstructorName { get; set; }

        /// <summary>
        /// The name of the course
        /// </summary>
        public string CourseName 
        { 
            get => courseName;
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Must have a course name.");
                }

                courseName = value;
            } 
        }

        /// <summary>
        /// Number of credits for the course
        /// </summary>
        public byte NumberOfCredits 
        {
            get => numCredits;
            set
            {
                if(value >= maxCredits || value <= 0)
                {
                    throw new ArgumentException("Invalid number of credits.");
                }

                numCredits = value;
            } 
        }

    }
}
