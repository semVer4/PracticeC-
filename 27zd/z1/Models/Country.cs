using System.Text;

namespace z1
{
    public partial class Form1
    {
        public class Country
        {
            public string Name { get; set; }
            public double Area { get; set; }
            public double Population { get; set; }

            public override string ToString()
            {
                return new StringBuilder()
                    .AppendLine($"--->Country is {Name}")
                    .AppendLine($"\tarea is {Area}km2")
                    .AppendLine($"\tpopulation is {Population} millions people")
                    .ToString();
            }
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Name = "Form1";
            this.ResumeLayout(false);

        }
    }
}
