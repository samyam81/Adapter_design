using System;

namespace AdapterDesign
{
    public class AssignmentWork
    {
        private IPen p;

        public IPen GetP()
        {
            return p;
        }

        public void SetP(IPen p)
        {
            this.p = p;
        }

        public void WriteAssignment(string str)
        {
            p.Write(str);
        }
    }

    public interface IPen
    {
        void Write(string str);
    }

    public class PenAdapter : IPen
    {
        private PilotPen pp = new PilotPen();

        public void Write(string str)
        {
            pp.Mark(str);
        }
    }

    public class PilotPen
    {
        public void Mark(string str)
        {
            Console.WriteLine(str);
        }
    }

    class School
    {
        static void Main(string[] args)
        {
            IPen p = new PenAdapter();
            AssignmentWork aw = new AssignmentWork();
            aw.SetP(p);
            aw.WriteAssignment("I Won't.");
        }
    }
}
