# COViGNITE
## A CoVid-19 smart assistant

Taking up the COVID-19 challenge for *Call For Code 2020*, this is a chatbot solution which aims at getting answers related to the coronavirus easier for users. The chatbot can answer a variety of frequently asked questions related to COVID-19. Often we try to find the number of cases in the location where we live and to do that we need to browse/scroll through pages to find our state/district. This chatbot can make that process a breeze - it can fetch the location of the user uisng GPS/location API(s) and give the user the data which they need. The chatbot can quickly reply with the helpline number of the state or provide a list of approved testing laboratories nearby.
A user can assess his/her health situation and understand one's vulnerability by answering some simple questions through the chatbot. The chatbot can also guide the user to proper channels if he/she knows or suspects a person who may be suffering from the disease and wants to report the same.

The chatbot is housed in a web application. You can find it [here](https://covignite.eu-gb.mybluemix.net/)


**Application Snapshot**

![Image of Application 1](https://raw.githubusercontent.com/CloudKnightsADM/Covignite_IBM_CTS_CallForCode2020/master/Application%20and%20Watson%20Snapshots/Application%20image_Covignite_1.jpg)



![Image of Application 2](https://raw.githubusercontent.com/CloudKnightsADM/Covignite_IBM_CTS_CallForCode2020/master/Application%20and%20Watson%20Snapshots/Application%20image_Covignite_2.jpg)


**Watson Assistant Covignite embedded with webapp**

![Image of WatsonAssistant](https://raw.githubusercontent.com/CloudKnightsADM/Covignite_IBM_CTS_CallForCode2020/master/Application%20and%20Watson%20Snapshots/Watson%20Assistant%20embedded.jpg)


**Covignite Architecture Diagram**

![Image of Architecture Diagram](https://raw.githubusercontent.com/CloudKnightsADM/Covignite_IBM_CTS_CallForCode2020/master/IBM%20Resources/IBM%20Resource%20Snapshots/Covignite_Architectural_Diagram.jpg)


# IBM Cloud Resources used for building this app (COVIGNITE)


**IBM Resources Used**


![Image of IBM Resources Used](https://raw.githubusercontent.com/CloudKnightsADM/Covignite_IBM_CTS_CallForCode2020/master/IBM%20Resources/IBM%20Resource%20Snapshots/CloudKnight_Covignite_Resources.jpg)

**1) Watson Assistant**


Snap of Dialogue Skill


![Image of IBM dialouge skill Used](https://raw.githubusercontent.com/CloudKnightsADM/Covignite_IBM_CTS_CallForCode2020/master/IBM%20Resources/IBM%20Resource%20Snapshots/WatsonAssistant_Dialogue%20skill.jpg)

Snap of Search Skill


![Image of IBM search skill Used](https://raw.githubusercontent.com/CloudKnightsADM/Covignite_IBM_CTS_CallForCode2020/master/IBM%20Resources/IBM%20Resource%20Snapshots/WatsonAssistant_Search%20skill.jpg)

**2) Watson Discovery**


Snap of Watson Discovery 


![Image of watson_discovery Used](https://raw.githubusercontent.com/CloudKnightsADM/Covignite_IBM_CTS_CallForCode2020/master/IBM%20Resources/IBM%20Resource%20Snapshots/CloudKnight_Covignite_WatsonDiscovery.jpg)


Snap of Watson Discovery Web Crawler


![Image of watson_discovery crawler Used](https://raw.githubusercontent.com/CloudKnightsADM/Covignite_IBM_CTS_CallForCode2020/master/IBM%20Resources/IBM%20Resource%20Snapshots/CloudKnight_Covignite_WatsonDiscovery_WebCrawler.jpg)


**3) Cloud Foundry used to host the WebApp**

Snap of Cloud Foundry


![Image of cloudfoundry Used](https://raw.githubusercontent.com/CloudKnightsADM/Covignite_IBM_CTS_CallForCode2020/master/IBM%20Resources/IBM%20Resource%20Snapshots/Cloud%20Foundry.jpg)


**4) IBM Functions used to create a webhook**

Snap of Ibm Function (Node.js)

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
