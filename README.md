# Covignite_IBM_CTS_CallForCode2020
# Personalised covid-19 smart assistant

Chatbot solution which provides generic covid-19 related data across the world along with user specific data depending on where the user is at the moment. This implementation uses GPS/Location services to provide information about the number of cases reported nearby, test centers/labs accessible, local helpline numbers or the kind of zone the user is in (red/orange/green/containment zone). The chatbot can double as a smart health assistant by providing users with real time assistance in case it detects an anomaly in the user's health data like body temperature recently. This is achieved by integrating the chatbot with a IoT enabled device.

**Covignite Architecture Diagram**

![Image of Architecture Diagram](https://raw.githubusercontent.com/CloudKnightsADM/Covignite_IBM_CTS_CallForCode2020/master/IBM%20Resources/IBM%20Resource%20Snapshots/Covignite_Architectural_Diagram.jpg)


# IBM Cloud Resources used for building this app (COVIGNITE)


**IBM Resources Used**


![Image of IBM Resources Used](https://raw.githubusercontent.com/CloudKnightsADM/Covignite_IBM_CTS_CallForCode2020/master/IBM%20Resources/IBM%20Resource%20Snapshots/CloudKnight_Covignite_Resources.jpg)

**1) Watson Assistant**


Snap of Dialogue Skill


![Image of IBM dialouge skill Used](https://raw.githubusercontent.com/CloudKnightsADM/Covignite_IBM_CTS_CallForCode2020/master/IBM%20Resources/IBM%20Resource%20Snapshots/WatsonAssistant_Dialogue%20skill.jpg)

Snap of Search Skill


![Image of IBM search skill Used](https://raw.githubusercontent.com/CloudKnightsADM/Covignite_IBM_CTS_CallForCode2020/master/IBM%20Resources/IBM%20Resource%20Snapshots/WatsonAssistant_Dialogue%20skill.jpg)

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
