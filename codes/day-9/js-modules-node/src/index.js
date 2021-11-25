// const trainerExportsObject = require('./trainer')
const { Trainer } = require('./trainer')

// const joyTrainer = new trainerExportsObject.Trainer("joy", 1, 1000, "JS")
const joyTrainer = new Trainer("joy", 1, 1000, "JS")
console.log(joyTrainer.print())