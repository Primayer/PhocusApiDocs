# Primayer Phocus API documentation

Questions? Find us at [development@primayer.co.uk](mailto:development@primayer.co.uk)

# Phocus Data Access

The Primayer API provides access to the raw data recorded by the Xilog logger. To use the API third parties must provide an authorization token with each request. The authorization token can be found within the settings section of [PrimeWeb](http://cloud.primayer.com). 

# Methods


- [*logger*](#loggerserial-begin-end-token): Returns data for logger specified by date time range.
- [*loggers*](#loggersbegin-end-token): Returns all loggers specified by date time range.

# API


## logger(serial, begin, end, token)

##### Purpose
Returns all data for the logger within the date range

##### Signature
  1. Endpoint
    - http://api.primayer.com/api/phocus/logger
  2. Params
    - serial: (string - required)
      - logger serial number
   - begin: (string - MM/dd/yyyy - required)
      - Date at which to start querying logger data.
    - end: (string -  MM/dd/yyyy - required)
      - Date at which to finish querying logger data.
    - token: (string - required)
      - api authorization token.
      
##### Return Value
  An object, Check examples for object structure.

##### Example

```javascript
const path = 'http://api.primayer.com/api/phocus/logger?serial=12345&begin=01/01/2017&end=01/02/2017&token=00000000-0000-0000-0000-000000000000'

fetch(path).then(function(response) {
    console.log(response);
})
```

<br />

## loggers(begin, end, token)

##### Purpose
Returns array of loggers with data within the date range

##### Signature
   1. Endpoint
    - http://api.primayer.com/api/phocus/loggers
  2. Params
   - begin: (string - MM/dd/yyyy - required)
      - Date at which to start querying logger data.
    - end: (string -  MM/dd/yyyy - required)
      - Date at which to finish querying logger data.
    - token: (string - required)
      - api authorization token.
     
##### Return Value
  An array of objects, check examples for object structure:

##### Example

```javascript
const path = 'http://api.primayer.com/api/phocus/loggers?begin=01/01/2017&end=01/02/2017&token=00000000-0000-0000-0000-000000000000'

fetch(path).then(function(response) {
    console.log(response);
})
```

<br />
