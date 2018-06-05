using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticExample {
	class Technology {
		public enum DifficultyType {
			VeryDifficult = 1,
			Difficult,
			Moderate,
			Easy,
			VeryEasy
		};

		public static int Counter { get; set; } = 0; //this tracks how many instances of Technology that we create

		public int Id { get; set; }
		public string Name { get; set; }
		public DifficultyType Difficulty { get; set; }

		 //creating a method that we can run on constructors so that we don't have to repeat code
		private void Initialization() {
			this.Id = ++Counter;  //this sets a new Id every time a new class is instantiated
			this.Difficulty= Difficulty;  //sets the difficulty to 3 as a default
		}

		//this is creating a constructor -- note it has the same name as the class name and no return type (i.e., void)
		// if we don't create a constructor then a blank one is created for us -- hence when we instantiate we say "Test t1 = new Test();
		public Technology() {
			Initialization();
		}

		//constrcutor that allows user to pass in the name
		public Technology(string Name) {
			this.Name = Name; //this.Name means this class -- we use this to distinguish Name since they are spelled the same way
			Initialization();
		}

		//constructor passing 2 parameters
		public Technology(string Name, DifficultyType Difficulty) {
			Initialization();
			this.Name = Name;
			this.Difficulty = Difficulty; //make sure to put difficulty here after "Initialization()" or the Difficulty will go back to 3
		}
	}
}
