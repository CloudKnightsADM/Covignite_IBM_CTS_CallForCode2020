# COViGNITE
## A COVID-19 smart assistant

Taking up the COVID-19 challenge for *Call For Code 2020*, this is a chatbot solution which aims at getting answers related to the Coronavirus easier for users. The chatbot can answer a variety of frequently asked questions related to COVID-19. Often we try to find the number of cases in the location where we live and to do that we need to browse/scroll through pages to find our state/district. This chatbot can make that process an absolute breeze - it can fetch the location of the user using GPS/location API(s) and give the user the data which they need. The chatbot can quickly reply with the helpline number of the state or provide a list of approved testing laboratories nearby.
A user can assess his/her health situation and understand one's vulnerability by answering some simple questions through this chatbot. The chatbot can also guide the user to proper channels if he/she knows or suspects a person who may be suffering from the disease and wants to report the same.

The chatbot is housed in a web application. You can find it [here](https://covignite.eu-gb.mybluemix.net/)

Find the demo video over [here](https://youtu.be/QbQIdYhSEuc)



**The Web Application**
The web application is based on .NET Core and Blazor. The landing screen comprises of a dashboard containing the real time cases of COVID-19 across the world.

![Image of Application 3](https://raw.githubusercontent.com/CloudKnightsADM/Covignite_IBM_CTS_CallForCode2020/master/Application%20and%20Watson%20Snapshots/Application%20image_Covignite_3.jpg)

![Image of Application 1](https://raw.githubusercontent.com/CloudKnightsADM/Covignite_IBM_CTS_CallForCode2020/master/Application%20and%20Watson%20Snapshots/Application%20image_Covignite_1.jpg)

![Image of Application 2](https://raw.githubusercontent.com/CloudKnightsADM/Covignite_IBM_CTS_CallForCode2020/master/Application%20and%20Watson%20Snapshots/Application%20image_Covignite_2.jpg)


**Watson Assistant Covignite embedded in web application**
The assistant can be brought up by clicking the icon in the bootom right corner and we are greeted by the chatbot.

![Image of WatsonAssistant](https://raw.githubusercontent.com/CloudKnightsADM/Covignite_IBM_CTS_CallForCode2020/master/Application%20and%20Watson%20Snapshots/Watson%20Assistant%20embedded.jpg)


**Covignite Architecture Diagram**

![Image of Architecture Diagram](https://raw.githubusercontent.com/CloudKnightsADM/Covignite_IBM_CTS_CallForCode2020/master/IBM%20Resources/IBM%20Resource%20Snapshots/Covignite_Architectural_Diagram.jpg)

**Covignite Flow Diagram**

![Image of Architecture Diagram](https://raw.githubusercontent.com/CloudKnightsADM/Covignite_IBM_CTS_CallForCode2020/master/IBM%20Resources/IBM%20Resource%20Snapshots/Covignite_Flow_Chart.jpg)


# IBM Cloud Resources used for building this app (COVIGNITE)


**IBM Resources Used**

Here is a snap from the resources list in IBM cloud

![Image of IBM Resources Used](https://raw.githubusercontent.com/CloudKnightsADM/Covignite_IBM_CTS_CallForCode2020/master/IBM%20Resources/IBM%20Resource%20Snapshots/CloudKnight_Covignite_Resources.jpg)

![Image of IBM Resources_2 Used](https://raw.githubusercontent.com/CloudKnightsADM/Covignite_IBM_CTS_CallForCode2020/master/IBM%20Resources/IBM%20Resource%20Snapshots/CloudKnight_Covignite_Resources_2.jpg)

## 1) Watson Assistant
The primary communications and functions of the chatbot are controlled by a Dialog Skill. The bot recognizes intents from the user and then responds accordingly. There are branches and sub-branches in the dialog to direct the user to the appropiate flow. We make use of features like context variables to store information, webhook to call out our API, entities to create custom responses and options, etc.

![Image of IBM dialouge skill Used](https://raw.githubusercontent.com/CloudKnightsADM/Covignite_IBM_CTS_CallForCode2020/master/IBM%20Resources/IBM%20Resource%20Snapshots/WatsonAssistant_Dialogue%20skill.jpg)


The assistant also has a search skill which uses Watson Discovery to search for articles matching the user input. This is useful when the user wants to know something the bot doesnt exactly know about but can still search and find relevant information.

![Image of IBM search skill Used](https://raw.githubusercontent.com/CloudKnightsADM/Covignite_IBM_CTS_CallForCode2020/master/IBM%20Resources/IBM%20Resource%20Snapshots/WatsonAssistant_Search%20skill.jpg)

## 2) Watson Discovery
As stated earlier, the search skill in Assistant uses Watson Discovery to search and find relevant information. Here the search skill gathers data from various sources and processes them using natural language processing and other AI algorithms to create a data store
![Image of watson_discovery Used](https://raw.githubusercontent.com/CloudKnightsADM/Covignite_IBM_CTS_CallForCode2020/master/IBM%20Resources/IBM%20Resource%20Snapshots/CloudKnight_Covignite_WatsonDiscovery.jpg)

One of the components of our Discovery is a **Web Crawler** which digs through websites to create a data store. We can then query this data store to find info related to our input.

![Image of watson_discovery crawler Used](https://raw.githubusercontent.com/CloudKnightsADM/Covignite_IBM_CTS_CallForCode2020/master/IBM%20Resources/IBM%20Resource%20Snapshots/CloudKnight_Covignite_WatsonDiscovery_WebCrawler.jpg)


## 3) Cloud Foundry
IBM Cloud Foundry service is used to host the web application written in .NET Core. It provides a scalable and resilient infrastructure and the sourec code can be easily deployed using the IBM Cloud CLI or CI/CD pipelines

![Image of cloudfoundry Used](https://raw.githubusercontent.com/CloudKnightsADM/Covignite_IBM_CTS_CallForCode2020/master/IBM%20Resources/IBM%20Resource%20Snapshots/Cloud%20Foundry.jpg)


## 4) IBM Function

We have written a cloud function using the NodeJS runtime. This has actions which can be triggered using HTTP requests. The function calls various APIs depending on parameters to fetch cases data or helpline numbers. This cloud function is called from the Watson Assistant using the web hook functionality.

![Image of function Used](https://raw.githubusercontent.com/CloudKnightsADM/Covignite_IBM_CTS_CallForCode2020/master/IBM%20Resources/IBM%20Resource%20Snapshots/CloudKnight_Covignite_Function.jpg)


# Future Scope Covid-19 smart assistant

**Covignite IoT Diagram Integrated with Cloud Foundry app**

![Image of watson_IOT](https://raw.githubusercontent.com/CloudKnightsADM/Covignite_IBM_CTS_CallForCode2020/master/IBM%20Resources/IBM%20IoT%20Snaps%20_FutureScope/Covignite_IoT_Diagram.jpg)

# Present IoT Implementation Details

At present we have used ibm simulators which includes (Temparature, Humidity and Object Temparature) to simulate IoT data flow using NodeRed to Watson IoT platform.
Please find below snaps to get an overview of data flow. In future we can replace this simulating devices with sensors like DHT22 (measures atomospeheric temparature and humidity) as well as LM35 for measuring body temparature.


**1) IBM IoT Simulator devices**

![Image of watson_IOT_Simulators](https://raw.githubusercontent.com/CloudKnightsADM/Covignite_IBM_CTS_CallForCode2020/master/IBM%20Resources/IBM%20IoT%20Snaps%20_FutureScope/IoT_Simulated_Sensors.jpg)

**2) IBM Watson IoT Platform**

![Image of watson_IOT_Platform](https://raw.githubusercontent.com/CloudKnightsADM/Covignite_IBM_CTS_CallForCode2020/master/IBM%20Resources/IBM%20IoT%20Snaps%20_FutureScope/IOT_Platform.jpg)

**3) NodeRed**

![Image of Nodered](https://raw.githubusercontent.com/CloudKnightsADM/Covignite_IBM_CTS_CallForCode2020/master/IBM%20Resources/IBM%20IoT%20Snaps%20_FutureScope/NodeRed.jpg)


**4) Events Received from Sensor on Watson IoT**

![Image of eventsIot](https://raw.githubusercontent.com/CloudKnightsADM/Covignite_IBM_CTS_CallForCode2020/master/IBM%20Resources/IBM%20IoT%20Snaps%20_FutureScope/IoT_Sensor_Informations.jpg)

**5) Raw Data visualization from Sensors on Watson IoT**

![Image of rawdata](https://raw.githubusercontent.com/CloudKnightsADM/Covignite_IBM_CTS_CallForCode2020/master/IBM%20Resources/IBM%20IoT%20Snaps%20_FutureScope/IoT_Raw_Data.jpg)

**6) Logs on Watson IoT**

![Image of logs](https://raw.githubusercontent.com/CloudKnightsADM/Covignite_IBM_CTS_CallForCode2020/master/IBM%20Resources/IBM%20IoT%20Snaps%20_FutureScope/IoT_Logs.jpg)


# Watson Voice Agent Integration

We have integrated watson voice agent using Twilio VoIP number and SIP voice trunk. We can also avail the paid service to get a personalised number and use "COVIGNITE" as an immediate voice assiatant. All you have to do is just dial the number.

Resources which we used to integrate watson assitant with voice agant.
Note: Here we have used trial Twilio account.

**1) Twilio number**

![Image of twlio](https://raw.githubusercontent.com/CloudKnightsADM/Covignite_IBM_CTS_CallForCode2020/master/IBM%20Resources/TWILIO/Twilio.jpg)

**2) Create Twilio SIP Trunk**

![Image of twlio_trunk](https://raw.githubusercontent.com/CloudKnightsADM/Covignite_IBM_CTS_CallForCode2020/master/IBM%20Resources/TWILIO/Twilio_SIP_Trunk.jpg)


**3) Watson Voice Agent**

![Image of Watson_Voice_agent](https://raw.githubusercontent.com/CloudKnightsADM/Covignite_IBM_CTS_CallForCode2020/master/IBM%20Resources/IBM%20Resource%20Snapshots/Watson_Voice_Agent.jpg)


![Image of Watson_Voice_agent_1](https://raw.githubusercontent.com/CloudKnightsADM/Covignite_IBM_CTS_CallForCode2020/master/IBM%20Resources/IBM%20Resource%20Snapshots/Voice_Agent%201.jpg)


![Image of Watson_Voice_agent_2](https://raw.githubusercontent.com/CloudKnightsADM/Covignite_IBM_CTS_CallForCode2020/master/IBM%20Resources/IBM%20Resource%20Snapshots/Voice_Agent_2.jpg)
