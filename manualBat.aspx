<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="manualBat.aspx.cs" Inherits="YourNamespace.LiveStreaming" %>

<!DOCTYPE html>
<html>
<head>
    <title>Live Video Streaming</title>
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.6.0/jquery.min.js"></script>
    <script>
        // Function to update the video frame
        function updateVideo() {
            $.ajax({
                url: 'GetVideoFrame.aspx',
                success: function (data) {
                    // Update the video source with the received frame
                    $('#videoFrame').attr('src', 'data:image/jpeg;base64,' + data);
                },
                error: function () {
                    console.log('Failed to fetch video frame.');
                },
                complete: function () {
                    // Schedule the next update after 100 milliseconds
                    setTimeout(updateVideo, 100);
                }
            });
        }

        // Start the video update when the page loads
        $(document).ready(function () {
            updateVideo();
        });
    </script>
</head>
<body>
    <video id="videoPlayer" autoplay></video>
</body>
</html>
