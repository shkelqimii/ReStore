import { Box, Typography } from "@mui/material";
import Slider from "react-slick";

export default function HomePage() {
    // eslint-disable-next-line @typescript-eslint/no-unused-vars
    const settings = {
        dots: true,
        infinite: true,
        speed: 500,
        slidersToShow: 1,
        slidersToScroll: 1
    };
    return(
        <>
            <Slider {...settings}>
                <div>
                    <img src="/images/hero1.jpg" alt="hero" style={{display: 'block', width: '100%', maxHeight:500}} />
                </div>
                <div>
                    <img src="/images/hero2.jpg" alt="hero" style={{display: 'block', width: '100%', maxHeight:500}} />
                </div>
                <div>
                    <img src="/images/hero3.jpg" alt="hero" style={{display: 'block', width: '100%', maxHeight:500}} />
                </div>
            </Slider>
            <Box display='flex' justifyContent='center' sx={{p: 4}}>
                <Typography variant='h1'>
                    Welcome to the Shop!
                </Typography>

            </Box>
        
        </>

    )
}