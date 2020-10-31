# Truck Simulator Key Server
Truck Simulator Key Server is an application that send keys pressed in a web dashboard to the game.

  - Truck Simulator Key Server works with Ets2 Telemetry Server!
  - Skins are the same as Ets2 Telemetry Server with few changes
  - This is an open source alternative to existing paid apps that do the same

# Installation
The installation is straight forward, just download the source code and compile it or just download the first release.

  - Open Ets2 Telemetry Server
  - Copy the folder of Truck Simulator Key Server in a convenient location. Next to the server folder from Ets2 Telemetry Server is a perfect location.
  - Run both Ets2 Telemetry Server and Truck Simulator Key Server
  - Skins are installed into Ets2 Telemetry Server. A demo skin is provided in the release and also in the source code.

# Configuration
In order to work properly we need to configure two things: one in the Truck Simulator Key Server and other in the skins we are going to use/make.
- Truck Simulator Key Server: Next to the executable there is a configuration file called appsettings.json, here we pick a port. By default the Hostname will be http://0.0.0.0:8888, this means your ip plus port 8888. In order to change the port just change the 8888 for the port you want to use. The IP can be 0.0.0.0, this means your current local IP will be selected.
- In the dashboard.js of the skin will be a variable called API_URL, replace the IP for your IP plus the port you chose.

# Demo
Here is a little video demonstrating how to control some aspects of the truck with a tablet.

[![](http://img.youtube.com/vi/_HAQy04bTTo/0.jpg)](http://www.youtube.com/watch?v=_HAQy04bTTo "")

# Create Skins
The skin creation is the same as Ets2 Telemetry Server but in order to work you need to write a function inside dashboard.js and put some attributes to the images or buttons you want to use.

First the function:
```javascript
    var API_URL = 'http://192.168.1.186:8888/api/v1/gateway'; //replace this IP for yours!!!!
    $('.send-key').on('click', function(){
        $.ajax({
            url: API_URL,
            data: JSON.stringify({"KeyName" : $(this).data('keyname'), "KeyCode" : $(this).data('keycode')}),
            type: 'post',
            dataType: 'json',
            contentType: 'application/json',
            success: function (data) {
                console.log(data);
            }           
        });
    });
```
This needs to live inside initialize function.
After you have the function ready you need to bind actions and to do that we use tags like this:

```html
<div class="truck-engineOn send-key" data-keyname="Letter E" data-keycode="E"></div>
```
- send-key: a class that must be in all of the elements you want to interact
- data-keyname: visible name, not relevant. Could be blank or something that helps you remember the input.
- data-keycode: This is the key we want to send. 
- There is a list of keys that can be found when you run the API at the url: http://your-ip:8888/api/v1/gateway/keys just pasting that url in a web browser.
