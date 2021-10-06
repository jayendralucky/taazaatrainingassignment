class Vehicle {
    constructor(name, maker, engine) {
      this.name = name;
      this.maker =  maker;
      this.engine = engine;
    }
  }
    
  let car1 = new Vehicle('GT', 'BMW', '1998cc');
    
  console.log(car1.name); 
  console.log(car1.engine);
  console.log(car1.maker);