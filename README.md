# FactoryDesignPattern
factory pattern is one of the most used design patterns.


Welcome to the FactoryDesignPattern wiki!
![image](https://user-images.githubusercontent.com/54809854/190173192-04b1bf6a-d7b7-47d4-919d-c8e92359d77d.png)

Benefits
1. Decouple the consumer from the product.
2 Use details from the current state or user input to create the product
3. Subclassed objects can be created.
4. Enable dependency injection
![image](https://user-images.githubusercontent.com/54809854/190173599-c87b5d51-cc73-432e-8114-04173d33ce76.png)

In the example of this repo is below:
We have a order to be shipped and email will be sent if the code is in release mode. While debugging of code we don't want to sent an email to user. We have encapsulated IUserNotifier interface and this interface will be implemented in two class email and test class. 
Now notificationserviceprovider have factory method GetUserNotifier logic basis on debug or release mode. you can update logic as per your requirement to keep a variable in config to know its testing mode or prod mode. 
Finally ShippingService will call service provider to ship method to send the notification. 
