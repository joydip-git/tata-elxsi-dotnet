"use strict"
export class Person {
    // private name: string;
    // private id: number;
    // private salary: number;

    // constructor(name: string, id: number, salary: number) {
    //     this.name = name;
    //     this.id = id;
    //     this.salary = salary;
    // }

    constructor(private _name: string, private _id: number, private _salary: number) {
    }

    public set name(value: string) {
        this._name = value;
    }
    public get name(): string {
        return this._name;
    }
    public get salary(): number {
        return this._salary;
    }
    public set salary(value: number) {
        this._salary = value;
    }
    public get id(): number {
        return this._id;
    }
    public set id(value: number) {
        this._id = value;
    }
    print(): string {
        return `${this._name}, ${this._salary}`
    }
}