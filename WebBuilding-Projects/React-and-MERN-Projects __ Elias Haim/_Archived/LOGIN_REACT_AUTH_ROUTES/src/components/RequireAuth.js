import { useLocation, Navigate, Outlet } from "react-router-dom";
import useAuth from "../context/AuthProvider";

const RequireAuth = ({ allowedRoles }) => {
    const { auth } = useAuth();
    const location = useLocation();

    return (<>
    
    {console.log(allowedRoles)}
        {console.log(auth)}
        {auth?.roles?.find(role => allowedRoles?.includes(role)) ? <Outlet />
            : auth?.email ? <Navigate to="/unauthorized" state={{ from: location }} replace />
            : <Navigate to="/login" state={{ from: location }} replace />}
    </>);
}

export default RequireAuth;