class HelloWorld {
    greeting: string;

    constructor(message: string) {
        this.greeting = message;
    }

    greet() {
        return "Hello, " + this.greeting;
    }
}

let greeter = new HelloWorld("world");
console.log(greeter.greet()); // Outputs: Hello, world