import React, { Component } from 'react';

export class UserData extends Component {
    static displayName = UserData.name;

    constructor(props) {
        super(props);
        this.state = { users: [], loading: true };
    }

    componentDidMount() {
        this.populateUsersData();
    }

    static renderForecastsTable(users) {
        return (
            <table className='table table-striped' aria-labelledby="tabelLabel">
                <thead>
                    <tr>
                        <th>User ID</th>
                        <th>Unique ID </th>
                        <th>User Name</th>

                    </tr>
                </thead>
                <tbody>
                    {users.map(user =>
                        <tr key={user.userID}>
                            <td>{user.userID}</td>
                            <td>{user.userKey}</td>
                            <td>{user.userName}</td>
                        </tr>
                    )}
                </tbody>
            </table>
        );
    }

    render() {
        let contents = this.state.loading
            ? <p><em>Loading...</em></p>
            : UserData.renderForecastsTable(this.state.users);

        return (
            <div>
                <h1 id="tabelLabel" >Weather forecast</h1>
                <p>This component demonstrates fetching data from the server.</p>
                {contents}
            </div>
        );
    }

    async populateUsersData() {
        const response = await fetch('api/users');
        const data = await response.json();
        this.setState({ users: data, loading: false });
    }
}
