namespace Suls.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    using  static Common.Constant.SubmissionConstant;
    public class Submission
    {
        public Submission()
        {
            this.Id = Guid.NewGuid().ToString();
        }
      public string Id { get; set; }

      [MaxLength(CodeMaxLength)]
      [Required]
       public string Code { get; set; }

       [MaxLength(AchievedResultMaxLength)]
       [Required]
       public int AchievedResult { get; set; }

       [Required]
       public DateTime CreatedOn { get; set; }

       public string ProblemId { get; set; }
       public virtual Problem Problem { get; set; }

       public string UserId { get; set; }
       public virtual User User { get; set; }

    }
}
