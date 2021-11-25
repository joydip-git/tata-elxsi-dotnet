import { IManager } from "../models/IManager";
import { Person } from "../models/person";
import { people } from "../repository/peoplerepository";

export class PeopleManager implements IManager<Person, string> {

    public add(person: Person): boolean {
        try {
            const found = people.find(p => p.id === person.id)
            if (!found) {
                people.push(person);
                return true;
            }
            return false;
        } catch (error) {
            throw error;
        }
    }
    public fetch(): Person[] {
        return [...people];
    }
    public search(name: string): Person[] {
        try {
            const filtered = people.filter(p => p.name.toLocaleLowerCase().indexOf(name.toLocaleLowerCase()) !== -1)
            return filtered;
        } catch (error) {
            throw error;
        }
    }
}