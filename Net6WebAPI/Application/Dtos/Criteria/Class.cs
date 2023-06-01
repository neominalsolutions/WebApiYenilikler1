namespace Net6WebAPI.Application.Dtos.Criteria
{
    public class CriteriaDto
    {
        public int Page { get; set; } = 1; // 1
        public string OrderBy { get; set; } // Name asc
        public string ThenBy { get; set; } // LastName desc

        public string SearchText { get; set; } // like '%name%'
        public int Limit { get; set; } = 10; // 10 


    }
}
