I developed the backend for a web application we built for the iTec Hackathon, where I participated with two classmates. Our task was to create an app that tracks other applications and their endpoints.

Users can register applications and their endpoints, and also report on the status of other applications' endpoints. As a user, you can view reports for the endpoints you’ve registered.

The app provides statistics on all registered applications and their endpoints, showing how many were stable, unstable, or down. The SQL database has a job that simulates calling all the endpoints every few seconds, returning random results.

If the last ten calls were successful, the endpoint is marked as stable. If at least one failed, it’s considered unstable, and if all ten failed, the endpoint is down.

I used the ASP.NET framework along with Dapper for data mapping.
