using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba2
{
    public abstract class Builder
    {
        public abstract void BuildDiagram();
        public abstract void BuildText();
        public abstract void BuildGraphic();
        public abstract Report GetResult();
    }

    public class Report
    {
        List<string> parts = new List<string>();
        public void Add(string s)
        {
            parts.Add(s);
        }
        public List<string> getReport()
        {
            return parts;
        }
    }
    public class ReportBuilder : Builder
    {
        Report report = new Report();
        public override void BuildDiagram()
        {
            report.Add("SomeDiagram");
        }
        public override void BuildGraphic()
        {
            report.Add("SomeGraphic");
        }
        public override void BuildText()
        {
            report.Add("SomeText");
        }
        public override Report GetResult()
        {
            return report;
        }
    }
}
