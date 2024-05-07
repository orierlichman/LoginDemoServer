using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace LoginDemoServer.DTO
{
    public class Grade
    {

        public DateTime Date { get; set; }

        public string SubjectName { get; set; }

        public int TestGrade { get; set; }

        public string Email { get; set; } = null!;

        public virtual User? EmailNavigation { get; set; }

        public Models.Grade ToModelsGrade()
        {
            return new Models.Grade() { Date = Date, SubjectName = SubjectName, TestGrade = TestGrade, Email = Email};
        }

        public Grade(Models.Grade modelGrade)
        {
            this.Date = modelGrade.Date;
            this.SubjectName = modelGrade.SubjectName;
            this.TestGrade = modelGrade.TestGrade;
            this.Email = modelGrade.Email;
        }
    }
}
