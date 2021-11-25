import { Person } from './person';

export class Trainer extends Person {
     
    //private domain:String;
    constructor(name:string, id:number, salary:number, private _domain: string) {
        super(name, id, salary)
        //this.domain = domain;
    }
    public get domain(): string {
        return this._domain;
    }
    public set domain(value: string) {
        this._domain = value;
    }  
    print() {
        return `${super.print()}, ${this._domain}`
    }
}
