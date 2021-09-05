using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOOP_School_System
{
    class Course : Lecturer
    {
        private string courseID;
        private string courseName;
        private string location;
        private string classStart;
        private string classEnd;
        private string fee;
        private string lecturerID2;
        private string duration;
        private string dayOfWeek;
        private SQL course_info;

        public string CourseID
        {
            get
            {
                return courseID;
            }
            set
            {
                courseID = value;
                course_info.Column_SELECT_1 = "*";
                course_info.Table = "Course";
                course_info.Column_WHERE_1 = "CourseID";
                course_info.String_Condition_1 = courseID;

                course_info.Construct();
                course_info.GetData(9);
                courseName = course_info.ResultGetData[1];
                location = course_info.ResultGetData[2];
                classStart = course_info.ResultGetData[3];
                classEnd = course_info.ResultGetData[4];
                fee = course_info.ResultGetData[5];
                lecturerID2 = course_info.ResultGetData[6];
                duration = course_info.ResultGetData[7];
                dayOfWeek = course_info.ResultGetData[8];
            }
        }
        public string CourseName
        {
            get
            {
                return courseName;
            }
        }
        public string Location
        {
            get
            {
                return location;
            }
        }
        public string ClassStart
        {
            get
            {
                return classStart;
            }
        }
        public string ClassEnd
        {
            get
            {
                return classEnd;
            }
        }
        public string Fee
        {
            get
            {
                return fee;
            }
        }
        public string LecturerID2
        {
            get
            {
                return lecturerID2;
            }
        }

        public string Duration
        {
            get
            {
                return duration;
            }
        }
        public string DayOfWeek
        {
            get
            {
                return dayOfWeek;
            }
        }
        
    }
}
