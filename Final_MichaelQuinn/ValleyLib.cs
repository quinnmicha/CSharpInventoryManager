using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ValleyLibrary
{
    class ValleyLib
    {
        public static bool IsDateBetweenYears(string x, int earliestValidYear, int latestValidYear)
        {//date must be a string in mm/dd/yyyy format
            //breaks string into month day year
            //validates that date is within years specified
            bool answer = false;
            string[] mDY = x.Split('/');
            answer = int.TryParse(mDY[0], out int month);
            if (answer == true)
            {
                if (month >= 01 && month <= 12)
                {
                    answer = int.TryParse(mDY[1], out int day);
                    if (answer == true)
                    {
                        if (day >= 01 && day <= 31)
                        {
                            answer = int.TryParse(mDY[2], out int year);
                            if (answer == true)
                            {
                                if (year <= earliestValidYear && year >= latestValidYear)
                                {
                                    answer = IsRealDay(month, year, day);
                                }
                                else { answer = false; }
                            }
                        }
                        else { answer = false; }
                    }
                }
                else { answer = false; }

            }

            return answer;
        }

        private static bool IsRealDay(int mo, int yr, int dy)
        {
            bool answer = false;
            int realDays = System.DateTime.DaysInMonth(yr, mo);
            if (dy <= realDays) { answer = true; }
            return answer;
        }
        
        public static bool IsTodayOrPastDate(string date)
        {//Includes Today
            bool answer = false;
            string[] mDY = date.Split('/');
            answer = int.TryParse(mDY[0], out int month);
            if (answer == true)
            {
                if (month >= 01 && month <= 12)
                {
                    answer = int.TryParse(mDY[1], out int day);
                    if (answer == true)
                    {
                        if (day >= 01 && day <= 31)
                        {
                            answer = int.TryParse(mDY[2], out int year);
                            if (answer == true)
                            {
                                answer = IsRealDay(month, year, day);
                                if(answer == true)
                                {
                                    DateTime.TryParse(date, out DateTime newDate);
                                    if (newDate <= System.DateTime.Today)
                                    {
                                        answer = true;
                                    }
                                    else { answer = false; }
                                }
                            }
                        }
                        else { answer = false; }
                    }
                }
                else { answer = false; }

            }

            return answer;
        }

        public static bool IsDateReal(string date)
        {
            bool answer = false;
            string[] mDY = date.Split('/');
            answer = int.TryParse(mDY[0], out int month);
            if (answer == true)
            {
                if (month >= 01 && month <= 12)
                {
                    answer = int.TryParse(mDY[1], out int day);
                    if (answer == true)
                    {
                        if (day >= 01 && day <= 31)
                        {
                            answer = int.TryParse(mDY[2], out int year);
                            if (answer == true)
                            {
                                answer = IsRealDay(month, year, day);
                            }
                        }
                        else { answer = false; }
                    }
                }
                else { answer = false; }

            }

            return answer;
        }

        public static bool ErrorCheckDoubBetween(string x, double min, double max)
        {
            bool answer = false;
            answer = double.TryParse(x, out double y);
            if (answer == true)
            {
                if (y >= min && y <= max)
                {
                    answer = true;
                }
                else { answer = false; }
            }
            return answer;
        }

        public static bool IsStringIntAndBetween(string x, int minLength, int maxLength)
        {
            bool answer = false;
            if (x.Length >= minLength && x.Length <= maxLength)
            {
                answer = int.TryParse(x, out int y);


            }
            return answer;
        }
		

        public static bool IsIntBetweenLength(int x, int minLength, int maxLength)
        {
            bool answer = false;
			string y = x.ToString();
            if (y.Length >= minLength && y.Length <= maxLength)
            {
                answer = true;


            }
            return answer;
        }

        public static void ErrorClear(Label errorName)
        {
            errorName.Visible = false;
        }

        public static int ErrorMsg(Label errorName, string msg, int errCount)// Not sure why it has to be static but it does
        {
            errorName.Text = msg;
            errorName.Visible = true;
            errCount++;
            return errCount;
        }

        public static bool IsFilled(string x)
        {
            bool answer = false;
            if (x == "")
            {
                answer = false;
            }
            else { answer = true; }
            return answer;
        }

        public static bool IsInt(string txt)
        {
            string answer = txt;
            bool isNum = int.TryParse(answer, out int number);
            return isNum;
        }
        public static bool IsStringWholeNumber(string txt)
        {
            string answer = txt;
            bool isNum = int.TryParse(answer, out int number);
            if (number < 1) { isNum = false; }
            return isNum;
        }
        public static bool IsDec(string txt)
        {
            string answer = txt;
            bool isNum = decimal.TryParse(answer, out decimal number);
            return isNum;
        }
        public static bool IsDoub(string txt)
        {
            string answer = txt;
            bool isNum = double.TryParse(answer, out double number);
            return isNum;
        }
        public static bool IsDoubOver0(string txt)
        {
            bool isNum = double.TryParse(txt, out double number);
            if (number <= 0) { isNum = false; }
            return isNum;
        }
    }
}
