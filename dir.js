client.request('SET_ACTIVITY',
    pid: process.pid,
    activity : {
        details : "get_details",
        assets : {
            large_image : "get_image",
            large_text : "get_text"
        },{
})