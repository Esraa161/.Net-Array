namespace ConsoleApp1
{
    internal class Program  
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World 1 !");
            string s1 = "Esraa";
            string s2 = "Emad";
            string s3 = s1 + " " + s2;
            string s4 = $"{s1} {s2}";
            Console.WriteLine(s3);
            Console.WriteLine(s4);
            ///.....................................................................................................................
            ////////////////////////////Array/////////////////////////////////////////////////
            string[] friends = new string[5] { "esraa", "emad", "hamdy", "mahmoud", "hh" };
            string[] friends2 =  { "esraa", "emad", "hamdy", "mahmoud", "hh" };
            var friends3 = new string[] { "esraa", "emad", "hamdy", "mahmoud", "hh" };
            var slice1 = friends[..2];
            var slice2 = friends[2..];
            var slice3 = friends[2..3];
            var slice4 = friends[2..^2];
            var slice5Range = 2..4;
            var slice5 = friends[slice5Range];  
            friends.print();
            friends2.print();
            friends3.print ();
            slice1.print();
            slice2.print();
            slice3.print();
            slice4.print(); 
            slice5.print();
            /////////////////////////////multi dimintional array///////////////////////
            int[,] mArray = { { 1, 2, 3 },
            { 4,5,6} };
            ///////////////////// jagged array : array inside array////////////////
            var jadded = new int[][]{
                        new int[]{1,2},
                        new int[]{3}
             };
            
        }
    }
    public static class Extensions
    {
        public static void print<T>(this T[] source)
        {
            if (!source.Any())
            {
                Console.WriteLine("{}");
                return;
            }
            Console.Write("{");
            for(int i=0; i<source.Length; i++)
            {
                Console.Write(source [i]);
                Console.Write(i<source.Length-1 ? "," : "");
            }
            Console.WriteLine("}");
        }
    }
}
