import { Component } from "@angular/core";

//decorator function: Component
@Component({
    selector: 'app-root',
    templateUrl: './app.component.html'
})
export class AppComponent {
    width = 100
    message = 'welcome to angular'
    constructor() {
        console.log('app component created')
    }

    changeSize(size: number) {
        this.width = size
    }
}