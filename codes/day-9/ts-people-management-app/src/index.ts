import { PeopleManager } from "./manager/peoplemanager";
import { Trainer } from "./models/trainer";

const joyTrainer: Trainer = new Trainer("joy", 1, 1000, "JS")
const manager = new PeopleManager();
manager.addPerson(joyTrainer);
console.log(manager.GetPeople())