namespace EntityAccess.Model
{
	public class Study
	{
		public int Id { get; set; }
		public int IdStudent { get; set; }
		public int IdCareer { get; set; }
		public virtual Student Student { get; set; }
		public virtual Career Career { get; set; }
	}
}
