Funbit.Ets.Telemetry.Dashboard.prototype.initialize = function (skinConfig, utils) {
    //
    // skinConfig - a copy of the skin configuration from config.json
    // utils - an object containing several utility functions (see skin tutorial for more information)
    //

    // this function is called before everything else, 
    // so you may perform any DOM or resource initializations / image preloading here

    utils.preloadImages([
        'images/bg-off.jpg', 'images/bg-on.jpg', 'images/beacon-off.png', 'images/beacon-on.png',
        'images/cruise-ctrl-desc.png', 'images/cruise-ctrl-inc.png', 'images/cruise-ctrl-off.png',
        'images/cruise-ctrl-on.png', 'images/engine-off.png', 'images/engine-on.png', 'images/high-beam-off.png',
        'images/high-beam-on.png', 'images/lights-off', 'images/lights-on.png', 'images/lights-on-mid.png',
        'images/wipers-off.png', 'images/wipers-on.png'
    ]);

    var API_URL = 'http://your-ip:8888/api/v1/gateway'; //replace this IP for yours!!!!
    

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

}

Funbit.Ets.Telemetry.Dashboard.prototype.filter = function (data, utils) {
    //
    // data - telemetry data JSON object
    // utils - an object containing several utility functions (see skin tutorial for more information)
    //

    // This filter is used to change telemetry data 
    // before it is displayed on the dashboard.
    // You may convert km/h to mph, kilograms to tons, etc.

    // round truck speed
    data.truck.speedRounded = Math.abs(data.truck.speed > 0
        ? Math.floor(data.truck.speed)
        : Math.round(data.truck.speed));

    // other examples:

    // convert kilometers per hour to miles per hour
    data.truck.speedMph = data.truck.speed * 0.621371;
    // convert kg to t
    data.trailer.mass = (data.trailer.mass / 1000.0) + 't';
    // format odometer data as: 00000.0
    data.truck.odometer = utils.formatFloat(data.truck.odometer, 1);
    // convert gear to readable format
    data.truck.gear = data.truck.gear > 0 ? 'D' + data.truck.gear : (data.truck.gear < 0 ? 'R' : 'N');
    // convert rpm to rpm * 100
    data.truck.engineRpm = data.truck.engineRpm / 100;
    // return changed data to the core for rendering
    return data;
};

Funbit.Ets.Telemetry.Dashboard.prototype.render = function (data, utils) {
    //
    // data - same data object as in the filter function
    // utils - an object containing several utility functions (see skin tutorial for more information)
    //

    // we don't have anything custom to render in this skin,
    // but you may use jQuery here to update DOM or CSS
    $('.truck-cruiseControlInc').css("opacity", data.truck.cruiseControlOn == true ? 1 : 0.5);
    $('.truck-cruiseControlDec').css("opacity", data.truck.cruiseControlOn == true ? 1 : 0.5);
}