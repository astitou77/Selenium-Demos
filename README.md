# Test Framework Project

Create a Selenium Tests to trigger a <b>Web Browsers</b> user Agent session, and manipulate the generated <b>DOM</b> elements of the webpage received.

Selenium[ WebDriver( DOM = WebBrowser[ User_Agent ] ) ]


<br>
<h2>1. Web Browser</h2>
URL:   https://www.mozilla.org/en-CA/firefox/browsers/what-is-a-browser/ <br><br>

Browsers (e.g., Chrome, Firefox, Safari, Edge) render web pages, execute JavaScript, and manage the DOM structure.
Browsers are where the DOM is rendered and where the user interacts with websites. They are the environment in which tools like Selenium and WebDriver operate.




<br>
<h2>2. User Agent</h2>
URL:   ??? <br><br>

The user agent is a string that a web browser sends to a web server to identify itself, along with details about the browser and the operating system it is running on.

It allows web servers to tailor responses based on the browser type (e.g., serving different HTML for mobile and desktop versions of a website).

The user agent helps web servers identify the browser making requests. 
When automating browsers with Selenium/WebDriver, you can manipulate the user agent string to simulate different browsers or devices.


<br>
<h2>3. DOM : Document Object Model</h2>
URL:   https://dom.spec.whatwg.org/ <br><br>

Web browsers interpret the HTML/CSS of a webpage received from the server to create the DOM, allowing JavaScript to interact with and manipulate elements on a page.
Tools like Selenium interact with the DOM to automate user interactions with a webpage.




<br>
<h2>4. WebDriver</h2>
URL:   https://www.w3.org/TR/webdriver1/ <br>
REPO:  https://github.com/w3c/webdriver <br><br>

WebDriver is a protocol used for automating browsers. It allows a program (like Selenium) to send commands to a web browser to perform actions (e.g., click buttons, fill forms, retrieve data).

WebDriver acts as a bridge between Selenium (or other automation frameworks) and the web browser. It controls browser actions and interacts with the DOM via commands to simulate user interactions.

It's a Language-neutral (Python, C#, Java...etC) wire Protocol for out-of-process programs (ex.: Selenium framework) to remotely instruct the behavior of web browsers (ex.: Chrome, Firefox, Edge...etc)

It is primarily intended to allow web authors to write <b>TESTS</b> that automate a user agent from a separate controlling process (Ex.: Selenium application) 

Provided is a set of interfaces to discover and manipulate DOM elements in (HTML) web documents and to control the behavior of a user agent




<br>
<h2>5. Selenium</h2>
URL:   https://www.selenium.dev/ <br> 
URL:   https://www.selenium.dev/documentation/webdriver/ <br><br>

Selenium is a tool that uses WebDriver to automate interactions with web browsers, which involves manipulating the DOM of web pages.

A collection of language secific bindings to drive a browser. Create robust, browser-based regression automation suites and tests, to scale and distribute across many environments (Dev, Test, Staging, Prod)

