import {Box, Button, Center, Container, Heading, Input} from '@chakra-ui/react';
import React, {useState} from 'react';
import {Link, useHistory} from 'react-router-dom';
import {AuthenticationRoutes, ClientRoutes, WorkshopEmployeeRoutes} from '../../../../routing/routes';
import {useAuth} from '../../context/AuthProvider';
import {authorize} from '../../helpers/AuthService';
import {UserSignIn as UserSignInCredentials, UserType} from './../../helpers/AuthService.types';
import {button, errormsg, input} from './AuthorizationView.styles';

const AuthorizationView: React.FC = () => {
    const history = useHistory();
    const {getRole} = useAuth();

    const [username, setUsername] = useState('');
    const [password, setPassword] = useState('');
    const [error, setError] = useState(false);

    function onChangeUsername(e: React.FormEvent<HTMLInputElement>) {
        setUsername(e.currentTarget.value);
    }

    function onChangePassword(e: React.FormEvent<HTMLInputElement>) {
        setPassword(e.currentTarget.value);
    }
    function showError() {
        return error === false ? <></> : <Box style={errormsg}>Wrong credentials or user doesn't exist</Box>;
    }

    function submitLogin(username: string, password: string) {
        var user: UserSignInCredentials = {
            username: username,
            password: password,
        };

        authorize(user).then((res) => {
            if (res === true) {
                const role = getRole();
                if (role === UserType.WORKSHOP_EMPLOYEE) {
                    history.push(WorkshopEmployeeRoutes.CASES);
                } else if (role === UserType.CLIENT) {
                    history.push(ClientRoutes.CARS);
                }
            } else {
                setError(true);
            }
        });
    }

    return (
        <Center>
            <Container variant={'authorization'}>
                <Center>
                    <Heading as="h3" size="xl">
                        Sign in
                    </Heading>
                </Center>
                <Input value={username} onChange={onChangeUsername} placeholder="username" style={input} />
                <Input value={password} onChange={onChangePassword} type="password" placeholder="password" style={input} />

                <Button disabled={username === '' || password === ''} onClick={() => submitLogin(username, password)} style={button}>
                    Login
                </Button>
                {showError()}
                <Link to={AuthenticationRoutes.SIGNUP} style={button}>
                    Or sign up
                </Link>
            </Container>
        </Center>
    );
};
export default AuthorizationView;
