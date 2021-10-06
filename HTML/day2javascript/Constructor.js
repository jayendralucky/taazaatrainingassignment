class Person
          {
             constructor(name) 
             {
               this.name = name;
             }
             Display()
             {
               console.log(`Name =>`, this.name);
             }
           }
          let person = new Person('Mike'); 
          person.Display();