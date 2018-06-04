using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticExample {
	class Program {
		static void Main(string[] args) {

			Technology Git = new Technology();
			Git.Name = "Git/GitHub";
			//Git.Difficulty = 3; //don't need this because our construtor sets the difficulty with a default of 3
			//Technology.Counter = 1; //can't reference "Counter" via "Git.Counter" because it is static and can't be instantiated...
									 //... -- it can only relate to the type iteself rather than an instance of the type

			Technology SQL = new Technology();
			SQL.Name = "SQL Server";
			SQL.Difficulty = Technology.DifficultyType.Difficult;
			//Technology.Counter = 2; //if we do this and the program runs then the counter will have a value of 2 in the "Git" instance above

			Technology CSharp = new Technology("C Sharp");
			Technology EF = new Technology("EF", Technology.DifficultyType.VeryEasy);
		}
	}
}
