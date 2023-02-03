using System;
namespace PassWordGenerator.Models
{
	public class PassWordGeneratorViewModel
	{
		public int PassWordLenght { get; set; }
		public bool UpperCase { get; set; }
		public bool SpecialCaractor { get; set; }
		public string PassResult { get; set; }
	}
}

