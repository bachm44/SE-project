import axios from 'axios';
import {API_BASE_PATH, AuthenticationRoutes} from '../../../routing/routes';
import {MockedPhoneNumber, MockedUserType} from './AuthService.mocks';
import {UserSignIn, UserSignUp} from './AuthService.types';

export async function authorize(userCreds: UserSignIn): Promise<boolean> {
    try {
        const res = await axios.post(API_BASE_PATH + AuthenticationRoutes.USER + AuthenticationRoutes.SIGNIN, userCreds);
        localStorage.setItem('client_uuid', res.data.guid);
        return true;
    } catch (error) {
        localStorage.setItem('client_uuid', '');
        return false;
    }
}



export function getClientID(): string {
    let creds = localStorage.getItem('client_uuid');
    return creds ? creds : '';
}

export function logout(): void {
    localStorage.removeItem('client_uuid');
}

export function createUser(username: string, password: string): void {
    const userType = MockedUserType;
    const phoneNumber = MockedPhoneNumber;
    var user: UserSignUp = {
        username,
        password,
        userType,
        name: username,
        surname: username,
        phoneNumber,
    };
    axios
        .post(API_BASE_PATH + AuthenticationRoutes.USER, user)
        .then((res) => {
                localStorage.setItem('client_uuid', res.data.guid)
            }
        ) //400 exist, 200 success
        .catch((err) => console.log(err));
}
