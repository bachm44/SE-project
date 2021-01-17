import {Box} from '@chakra-ui/react';
import React from 'react';
import {Route, useHistory} from 'react-router-dom';
import {Menu} from '../../modules/common/components/Menu/Menu';
import {MENU_HEIGHT, MENU_WIDTH} from '../../modules/common/components/Menu/Menu.constants';
import {AuthenticationRoutes} from '../routes';
import {getRole, isAuthenticated} from "../../modules/authorization/helpers/AuthService"

type Props = {
    path: string;
    accountType: string
};

const RestrictedRoute: React.FC<Props> = ({children, path, accountType}) => {
    const history = useHistory();

    function getContent() {
        isAuthenticated().then(r=>{if(r===false){
            history.push(AuthenticationRoutes.SIGNIN)
       }})
        getRole().then(r=>{if(r!==accountType){
             history.push('/noaccess')
        }})
        return children;
    }

    return (
        <>
            <Menu />
            <Box paddingTop={`${MENU_HEIGHT + 24}px`} marginLeft={`${MENU_WIDTH + 24}px`}>
                <Route path={path}>{getContent()}</Route>
            </Box>
        </>
    );
};
export default RestrictedRoute;
