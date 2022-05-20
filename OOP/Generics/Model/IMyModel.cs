namespace Generics.Model
{
	public interface IMyModel
	{
		string Root();
		IMyModel ToModel(string str);
	}
}
