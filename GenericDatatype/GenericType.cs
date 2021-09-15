namespace GenericDatatype
{
    class GenericType
    {
        public int FindMax(int num1,int num2,int num3)
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
    }
}
