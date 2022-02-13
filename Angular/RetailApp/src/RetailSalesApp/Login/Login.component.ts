import { Component } from '@angular/core';
import { Customer } from './Login.model' 
@Component(
    {
        selector: 'login',
        templateUrl: './Login.component.html'
    })
export class LoginComponent 
{
    message1 = "";
    cus:Customer = new Customer();
    Challenge()
    {
        if(this.cus.Name == "sowndarya" && 
        this.cus.Password == "one")
        {
            this.message1 = "login successful!!"
        }
    }

}
