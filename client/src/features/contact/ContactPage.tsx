import { ButtonGroup, Typography } from "@mui/material";
import { useAppDispatch, useAppSelector } from "../../app/store/configureStore";
import { decrement, increment } from "./counterSlice";

export default function ContactPage() {
    const dispatch = useAppDispatch(); 
    const {data, title} = useAppSelector(state => state.counter);



    return(
        <>
            <Typography variant="h2">
                {title}
            </Typography>
            <Typography variant="h5">
                The data is: {data}
            </Typography>

            <ButtonGroup>
                <button onClick={() => dispatch(decrement(1))}  color='error'>Decrement</button>
                <button onClick={() => dispatch(increment(1))}  color='primary'>Increment</button>
                <button onClick={() => dispatch(increment(5))}  color='secondary'>Increment by 5</button>


            </ButtonGroup>
        </>

    )
}