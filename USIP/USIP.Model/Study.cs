namespace USIP.Model
{
	public class Study
	{
		public int Id { get; set; }
		public int IdStudent { get; set; }
		public int IdCareer { get; set; }
		public virtual Student Student { get; set; }
		public virtual User Career { get; set; }
	}
}
