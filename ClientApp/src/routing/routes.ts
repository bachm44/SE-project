export enum ClientRoutes {
    REPORT_ACCIDENT = '/report-accident',
    PROFILE = '/profile',
    CARS = '/cars',
    APPOINTMENTS = '/appointments',
    HISTORY = '/history',
}

export enum WorkshopEmployeeRoutes {
    CASE = '/case/:caseId',
    SCHEDULE = '/schedule',
    ORDERS = '/orders',
    PARTS_SHOP = '/parts-shop',
    CLIENTS = '/clients',
    HISTORY = '/history',
}

export enum InsuranceEmployeeRoutes {
    CLIENTS = '/clients',
    OFFERS = '/offers',
    INSURANCES = '/insurances',
}

export enum AuthenticationRoot {
        SIGNUP = "/signup",
        SIGNIN = "/signin",
        USER = "/user"
} 