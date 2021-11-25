export interface IManager<T, T1> {
    add(obj: T): boolean;
    fetch(): T[];
    search(val: T1): T[];
}

// interface IPerson{
//     name:string;
//     id:number;
//     salary:number;
//     domain:string;
// }