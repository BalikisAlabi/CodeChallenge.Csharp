const string = 'African Journal';

const encode = (stringToEncode) => {
  let subStringA = stringToEncode.slice(0, stringToEncode.length / 2).trim();
  let subStringB = stringToEncode.slice(stringToEncode.length / 2).trim();

  let newSubStringA = '';
  let newSubStringB = '';

  for (let i in subStringA) {
    if (i % 2 == 0) {
      newSubStringA += subStringA[i] + subStringB[i];
    } else {
      newSubStringB += subStringA[i] + subStringB[i];
    }
  }
  newA = newSubStringA.slice(0, -1);
  newB = newSubStringB + subStringB[subStringB.length - 1];
  encodedString = newB + newA;
  return encodedString;
};
console.log(`The encoded string is ${encode(string)}`);

const decode = (stringToDecode) => {
  let subStringA = stringToDecode.slice(0, stringToDecode.length / 2).trim();
  let subStringB = stringToDecode.slice(stringToDecode.length / 2).trim();
  let newSubStringA = '';
  let newSubStringB = '';
  for (let i in subStringA) {
    if (i % 2 == 1) {
      newSubStringA += subStringB[i] + subStringA[i];
    } else {
      newSubStringB += subStringB[i] + subStringA[i];
    }
  }

  newA = newSubStringA + subStringA[subStringA.length - 1];
  newB = newSubStringB.slice(0, -1);
  decodedString = `${newB} ${newA}`;
  return decodedString;
};

console.log(`The decoded string is ${decode(encode(string))}`);