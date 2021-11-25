import { Component } from "@angular/core";

//decorator function: Component
@Component({
    selector: 'app-root',
    template: '<div>welcome to angular</div>'
})
export class AppComponent {
    constructor() {
        console.log('app component created')
    }
}