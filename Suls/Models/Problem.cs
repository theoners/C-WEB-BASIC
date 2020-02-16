namespace Suls.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using static Common.Constant.ProblemConstant;
    public class Problem
    {
        public Problem()
        {
            this.Id = Guid.NewGuid().ToString();
        }


        public string Id { get; set; }

        [MaxLength(NameMaxLength)]
        [Required]
        public string Name { get; set; }

        [MaxLength(PointsMaxLength)]
        [Required]
        public int Points { get; set; }

        public virtual ICollection<Submission> Submissions { get; set; }
    }
}
