namespace selfanalyse.Computer
{
    public class Lucky
    {
        double Computer;
        readonly int studentid;
        static string file;
        
        public Lucky(int sid,double comp)
        {
            Computer = comp;
            studentid = sid;
        }
        static Lucky()
        {
            file="No files";
        }
        public int Studentid()
        {
            return studentid;
        }
        public static string Filename()
        {
            return file;
        }
        public double ComputerName()
        {
            return Computer;
        }

        
    }
}