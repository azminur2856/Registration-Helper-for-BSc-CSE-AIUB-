namespace Registration_Helper_for_BSc_CSE_AIUB
{
    internal class BSc_in_CSE_Curriculum
    {
        public string Code { get; set; }
        public string CourseDescription { get; set; }
        public string PreRequisite { get; set; }
        public int Credit { get; set; }
        public static readonly string Nil = "Nil";

        public BSc_in_CSE_Curriculum(string Code, string CourseDescription, string PreRequisite, int Credit)
        {
            this.Code = Code;
            this.CourseDescription = CourseDescription;
            this.PreRequisite = PreRequisite;
            this.Credit = Credit;
        }
    }
}
