namespace GenericDatatype
{
    class GenericType
    {
        public static int FindMax(int num1,int num2,int num3)
        {
            if(num1 > num2 && num1 > num3)
            {
                return num1;
            }
            else if (num2 > num1 && num2 > num3)
            {
                return num2;
            }
            else if (num3 > num2 && num3 > num1)
            {
                return num3;
            }
            else
            {
                return -1;
            }
            
        }
        public float FindMax(float num1, float num2, float num3)
        {
            if (num1 > num2 && num1 > num3)
            {
                return num1;
            }
            else if (num2 > num1 && num2 > num3)
            {
                return num2;
            }
            else if (num3 > num2 && num3 > num1)
            {
                return num3;
            }
            else
            {
                return -1;
            }

        }

        public string FindMax(string firstString,string secondString, string thirdString)
        {
            if (firstString.CompareTo(secondString) > 0 && firstString.CompareTo(thirdString)>0 ||
                firstString.CompareTo(secondString) >= 0 && firstString.CompareTo(thirdString) > 0 ||
                firstString.CompareTo(secondString) > 0 && firstString.CompareTo(thirdString) >= 0 
                )
            {
                return firstString;
            }
            else if(secondString.CompareTo(firstString) > 0 && secondString.CompareTo(thirdString) > 0 ||
                secondString.CompareTo(firstString) >= 0 && secondString.CompareTo(thirdString) > 0 ||
                secondString.CompareTo(firstString) > 0 && secondString.CompareTo(thirdString) >= 0
                )
            {
                return secondString;
            }
            else if (thirdString.CompareTo(firstString) > 0 && thirdString.CompareTo(secondString) > 0 ||
                thirdString.CompareTo(firstString) >= 0 && thirdString.CompareTo(secondString) > 0 ||
                thirdString.CompareTo(firstString) > 0 && secondString.CompareTo(secondString) >= 0
                )
            {
                return thirdString;
            }
            else
            {
                return "all string are same";
            }
                
        }
    }
}
