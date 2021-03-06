# Primayer Phocus API documentation

Questions? Find us at [development@ovarro.com](mailto:development@primayer.co.uk)

# Phocus Data Access

The Primayer API provides access to the data recorded by a Phocus/Enigma logger. To use the API third parties must provide an authorization token with each request. The authorization token can be found within the settings section of [PrimeWeb](https://cloud.primayer.com). The current endpoint api.primayer.com is being deprecated, please start using access.primayer.com instead.

# Methods

- [*logger*](#loggerserial-begin-end-token): Returns data for logger specified by date time range.
- [*loggers*](#loggersbegin-end-token): Returns all loggers specified by date time range.
- [*loggerinfo*](#loggerinfoserial-begin-end-token): Returns info for logger specified by date time range.
- [*allinfo*](#allinfobegin-end-token): Returns all loggers info specified by date time range.
- [*signal*](#signalserial-begin-end-token): Returns signal for logger specified by date time range.
- [*summary*](#summarydate-token): Returns all Enigma groups with leak count.
- [*group*](#groupgroupId-date-token): Returns leak summary for group.
- [*groupaudio*](#groupaudiodate-group-token): Returns audio for group.
- [*correlation*](#correlationleft-right-group-date-token): Returns PrimeWeb url to correlation
- [*contractloggers*](#contractloggersbegin-end-contract-token): Returns all loggers specified by date time and contract.
- [*contractallinfo*](#contractinfobegin-end-contract-token): Returns all loggers info specified by date time and contract.
- [*loggerreport*](#loggerreporttoken): CSV logger report.
- [*dmareport*](#dmareportbegin-end-token): CSV Phocus Dma report.
# API


## logger(serial, begin, end, token)

##### Purpose
Returns all data for the logger within the date range

##### Signature
  1. Endpoint
    - https://access.primayer.com/api/phocus/logger
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
const path = 'https://access.primayer.com/api/phocus/logger?serial=12345&begin=01/01/2017&end=01/02/2017&token=00000000-0000-0000-0000-000000000000'

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
    - https://access.primayer.com/api/phocus/loggers
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
const path = 'https://access.primayer.com/api/phocus/loggers?begin=01/01/2017&end=01/02/2017&token=00000000-0000-0000-0000-000000000000'

fetch(path).then(function(response) {
    console.log(response);
})
```

<br />

## loggerinfo(serial, begin, end, token)

##### Purpose
Returns all info for the logger within the date range

##### Signature
  1. Endpoint
    - https://access.primayer.com/api/phocus/loggerinfo
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
const path = 'http://access.primayer.com/api/phocus/loggerinfo?serial=12345&begin=01/01/2017&end=01/02/2017&token=00000000-0000-0000-0000-000000000000'

fetch(path).then(function(response) {
    console.log(response);
})
```

<br />

## allinfo(begin, end, token)

##### Purpose
Returns array of loggers with info within the date range

##### Signature
   1. Endpoint
    - https://access.primayer.com/api/phocus/allinfo
   2. Params
   - begin: (string - MM/dd/yyyy - required)
     - Date at which to start querying logger data
   - end: (string -  MM/dd/yyyy - required)
     - Date at which to finish querying logger data
   - token: (string - required)
     - api authorization token
     
##### Return Value
  An array of objects, check examples for object structure:

##### Example

```javascript
const path = 'https://access.primayer.com/api/phocus/allinfo?begin=01/01/2017&end=01/02/2017&token=00000000-0000-0000-0000-000000000000'

fetch(path).then(function(response) {
    console.log(response);
})
```

<br />

## signal(serial, begin, end, token)

##### Purpose
Returns signal data for the logger within the date range

##### Signature
  1. Endpoint
    - https://access.primayer.com/api/phocus/signal
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
const path = 'https://access.primayer.com/api/phocus/signal?serial=12345&begin=01/01/2017&end=01/02/2017&token=00000000-0000-0000-0000-000000000000'

fetch(path).then(function(response) {
    console.log(response);
})
```

<br />

## summary(date, token)

##### Purpose
Returns Enigma groups with leak count

##### Signature
   1. Endpoint
    - https://access.primayer.com/api/enigma/summary
   2. Params
   - date: (string - MM/dd/yyyy - required)
     - Date at which to get summary
   - token: (string - required)
     - api authorization token
     
##### Return Value
  An array of objects, check examples for object structure:

##### Example

```javascript
const path = 'https://access.primayer.com/api/enigma/summary?date=01/01/2017&token=00000000-0000-0000-0000-000000000000'

fetch(path).then(function(response) {
    console.log(response);
})
```

<br />

## group(groupId, date, token)

##### Purpose
Returns leak summary for group

##### Signature
   1. Endpoint
    - https://access.primayer.com/api/enigma/group
  2. Params
   - groupId: (Int - required)
     - group Id (returned in the summary)
   - date: (string - MM/dd/yyyy - required)
     - Date at which to get summary.
   - token: (string - required)
     - api authorization token.
     
##### Return Value
  An array of objects, check examples for object structure:

##### Example

```javascript
const path = 'https://access.primayer.com/api/enigma/group?groupId=1234&date=01/01/2017&token=00000000-0000-0000-0000-000000000000'

fetch(path).then(function(response) {
    console.log(response);
})
```

<br />

## groupaudio(date, group, token)

##### Purpose
Returns audio data for group

##### Signature
   1. Endpoint
    - https://access.primayer.com/api/enigma/groupaudio
  2. Params
   - date: (string - MM/dd/yyyy - required)
     - Date at which to get audio.
   - group: (Int - required)
     - group Id (returned in the summary)
   - token: (string - required)
     - api authorization token.
     
##### Return Value
  An array of objects, check examples for object structure:

##### Example

```javascript
const path = 'https://access.primayer.com/api/enigma/groupaudio?date=01/01/2017&group=1234&token=00000000-0000-0000-0000-000000000000'

fetch(path).then(function(response) {
    console.log(response);
})
```

<br />

## correlation(left, right, group, date, token)

##### Purpose
Returns PrimeWeb url for a correlation

##### Signature
   1. Endpoint
    - https://access.primayer.com/api/enigma/correlation
  2. Params
   - left: (string - required)
     - logger serial number
   - right: (string - required)
	 - logger serial number
   - group: (int - required)
     - group id
   - date: (string - MM/dd/yyyy - required)
     - Date at which to get summary
   - token: (string - required)
     - api authorization token
     
##### Return Value
  A url to the correlation screen on PrimeWeb

##### Example

```javascript
const path = 'https://access.primayer.com/api/enigma/correlation?left=123456&right=123456&group=1234&date=01/01/2017&token=00000000-0000-0000-0000-000000000000'

fetch(path).then(function(response) {
    console.log(response);
})
```

<br />

## contractloggers(begin, end, contract, token)

##### Purpose
Returns array of loggers with data within the date range

##### Signature
   1. Endpoint
    - https://access.primayer.com/api/contract/loggers
  2. Params
   - begin: (string - MM/dd/yyyy - required)
     - Date at which to start querying logger data.
   - end: (string -  MM/dd/yyyy - required)
     - Date at which to finish querying logger data.
   - contract: (string - required)
     - contract identifier
   - token: (string - required)
     - api authorization token.
     
##### Return Value
  An array of objects, check examples for object structure:

##### Example

```javascript
const path = 'https://access.primayer.com/api/contract/loggers?begin=01/01/2017&end=01/02/2017&contract=name&token=00000000-0000-0000-0000-000000000000'

fetch(path).then(function(response) {
    console.log(response);
})
```

<br />

## contractinfo(begin, end, contract, token)

##### Purpose
Returns array of loggers with info within the date range

##### Signature
   1. Endpoint
    - https://access.primayer.com/api/contract/allinfo
  2. Params
   - begin: (string - MM/dd/yyyy - required)
     - Date at which to start querying logger data.
   - end: (string -  MM/dd/yyyy - required)
     - Date at which to finish querying logger data.
   - contract: (string - required)
     - contract identifier
   - token: (string - required)
     - api authorization token.
     
##### Return Value
  An array of objects, check examples for object structure:

##### Example

```javascript
const path = 'https://access.primayer.com/api/contract/allinfo?begin=01/01/2017&end=01/02/2017&contract=name&token=00000000-0000-0000-0000-000000000000'

fetch(path).then(function(response) {
    console.log(response);
})
```

<br />

## loggerreport(token)

##### Purpose
Returns logger report csv

##### Signature
   1. Endpoint
    - https://access.primayer.com/api/enigma/loggerreport
  2. Params
   - token: (string - required)
     - api authorization token.
     
##### Return Value
  csv report

##### Example

```javascript
const path = 'https://access.primayer.com/api/enigma/loggerreport?token=00000000-0000-0000-0000-000000000000'

fetch(path).then(function(response) {
    console.log(response);
})
```

<br />

## dmareport(begin, end, token)

##### Purpose
Returns Phocus DMA report csv

##### Signature
   1. Endpoint
    - https://access.primayer.com/api/phocus/dmareport
  2. Params
   - begin: (string - MM/dd/yyyy HHmm - required)
     - Date at which to start querying.
   - end: (string -  MM/dd/yyyy HHmm - required)
     - Date at which to finish querying.
   - token: (string - required)
     - api authorization token.
     
##### Return Value
  csv report

##### Example

```javascript
const path = 'https://access.primayer.com/api/phocus/dmareport?begin=01/01/2017 0000&end=01/02/2017 0000&token=00000000-0000-0000-0000-000000000000'

fetch(path).then(function(response) {
    console.log(response);
})
```
<br />
