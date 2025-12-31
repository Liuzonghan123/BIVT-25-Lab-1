namespace Lab1
{
    public class White
    {
        public bool Task1(double d)
        {
            bool answer = false;

            // code here
            if (d > 0)
            {
                answer = true;
            }
            // end

            return answer;
        }
        public bool Task2(int n)
        {
            bool answer = false;

            // code here
            if (n % 2 == 0)
            {
                answer = true;
            }
            // end

            return answer;
        }
        public int Task3(int a, int b)
        {
            int answer = 0;

            // code here
            if (a > b)
            {
                answer = a;
            }
            else
            {
                answer = b;
            }
            // end

            return answer;
        }
        public double Task4(double d, double f)
        {
            
            double answer = 0;

            // code here

            if (Math.Abs(d) > Math.Abs(f))
            {
                answer = f;
            }
            else
            {
                answer = d;
            }
            // end

            return answer;
        }
        public double Task5(double x)
        {
            double answer = 0;

            // code here
            if (Math.Abs(x) > 1)
            {
                answer = 1;
            }
            else
            {
                answer = x;
            }
            // end

            return answer;
        }
        public bool Task6(double x, double y, double r)
        {
            bool answer = false;

            // code here
            double difference = Math.Abs(x * x + y * y - r * r);
            if (difference <= 0.0001)
            {
                answer = true;
            }

            // end

            return answer;
        }

        public bool Task7(int n)
        {
            bool answer = false;

            // code here
            { 
               

            // 1. 计算 s = n^2
                int s = n * n;

                // 2. 第一个判断框: s - n > 2*n
                if (s - n > 2 * n)
                {
                    // 3. 第二个判断框: n 是否为偶数
                    if (n % 2 == 0)
                    {
                        answer = true;
                    }
                }

                return answer;
            }
            // end

            return answer;
        }
        public bool Task8(double L, int T, int M)
        {
            bool answer = false;

            // code here
            // 条件1: 速度10海里/小时，时间不超过3小时 (L/10 <= 3)
            bool isTimeValid = (L / 10.0) <= 3;

            // 条件2: 标志物(树+山)总数不少于5
            bool areLandmarksEnough = (T + M) >= 5;

            // 条件3: 山的数量必须是偶数
            bool isMountainsEven = (M % 2 == 0);

            // 必须同时满足所有条件
            if (isTimeValid && areLandmarksEnough && isMountainsEven)
            {
                answer = true;
            }

            return answer;
        }
            // end

            
        }
    }
