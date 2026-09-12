using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstTekrar;

class StudentCard
{
    public int Id { get; set; }

    public DateTime StartDate { get; set; } = DateTime.Now;

    public DateTime EndDate { get; set; }

    public Student Student { get; set; }


    public override string ToString()
    {
        return $"Student card: Date {StartDate.ToShortDateString()} -- {EndDate.ToShortDateString()}";
    }
}
