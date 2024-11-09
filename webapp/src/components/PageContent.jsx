import { React, useState, useEffect } from 'react';
import { Typography, Row, Flex } from 'antd';

import { useDataFetch } from '../context/DataFetchContext';

import LoadingSkeleton from './LoadingSkeleton';
import CreateProductButton from './CreateProductButton';
import CardsList from './CardsList';

import axios from '../api/axios'

const { Title, Paragraph, Text } = Typography;

const PageContent = () => {
    const [page, setPage] = useState(1);
    const [pageSize, setPageSize] = useState(null);

    const [data, setData] = useState(null);
    const [error, setError] = useState(null);
    const [loading, setLoading] = useState(true);

    const { state, dispatch } = useDataFetch();

    useEffect(() => {
        if (state.isDataFetchActive) {
            fetchDataAsync();
            dispatch({ type: 'TOGGLE_FETCH' });
        }
    }, [state.isDataFetchActive, dispatch]);

    const fetchDataAsync = async () => {
        try {
            const response = await axios.get(`/api/products`, {
                params: {
                    "page": page,
                    "pageSize": pageSize
                },
            });
            console.debug(response);
            setData(response.data.products);
        }
        catch (error) {
            console.error(error);
            setError(error);
        }
        finally {
            setLoading(false);
        }
    }

    const ProductsPage = () => {
        if (data.length === 0)
            return (<Text style={{ fontSize: 18 }}>Товаров нет</Text>);

        return (<CardsList productsData={data} onDelete={setData} />);
    };

    if (error) {
        return (
            <Row justify="center" align="middle" style={{ height: '80vh' }}>
                <Paragraph>Возникла ошибка при загрузке товаров</Paragraph>
                <Paragraph>{error}</Paragraph>
            </Row>
        )
    }

    if (loading) {
        return <LoadingSkeleton />;
    }

    return (
        <>
            <Flex justify="space-between">
                <Title>Список товаров</Title>
                <CreateProductButton />
            </Flex>
            <ProductsPage />
        </>
    )
}

export default PageContent;