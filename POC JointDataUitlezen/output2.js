var Kinect2 = require('kinect2'); 

var kinect = new Kinect2();

if(kinect.open()) {
    console.log("Kinect Opened");
    //listen for body frames
    kinect.on('bodyFrame', function(bodyFrame){
		var user = bodyFrame.bodies[i];
		user.joints[1]
        for(var i = 0;  i < bodyFrame.bodies.length; i++) {
            if(bodyFrame.bodies[i].tracked) {
                console.log(user.joints[1].depthX);
            }
        }
    });

    //request body frames
    kinect.openBodyReader();

    //close the kinect after 5 seconds
    setTimeout(function(){
        kinect.close();
        console.log("Kinect Closed");
    }, 60000);
}